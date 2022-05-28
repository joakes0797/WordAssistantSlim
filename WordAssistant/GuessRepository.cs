using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using WordAssistant.Models;

namespace WordAssistant
{
    public class GuessRepository : IGuessRepository
    {
        //private readonly IDbConnection _conn;
        //public GuessRepository(IDbConnection conn)
        //{
        //    _conn = conn;
        //}
        //private readonly Answer _answer;
        public static readonly List<string> WordleAnswers = new() { "cigar", "rebut", "sissy", "humph", "awake", "blush",
            "focal", "evade", "naval", "serve", "heath", "dwarf", "model", "karma", "stink", "grade", "quiet", "bench", 
            "abate", "feign", "major", "death", "fresh", "crust", "stool" };

        public IEnumerable<string> GetResults(string green, string y1, string y2, string y3, string y4, string y5, string g01, string g02, string g03, string g04, string g05, string g06, string g07, string g08, string g09, string g10)
        {
            throw new System.NotImplementedException();
        }

        //public GuessRepository()
        //{
        //    _answer = new Answer();
        //}

        //public ienumerable<string> getresults(string green, string y1, string y2, string y3, string y4, string y5, string g01, string g02, string g03, string g04, string g05, string g06, string g07, string g08, string g09, string g10)
        //{
        //    //return _conn.query<word>("select * from words where name like @green and name like @y1 and name like @y2 and name like @y3 and name like @y4 and name like @y5 and name not like @g01 and name not like @g02 and name not like @g03 and name not like @g04 and name not like @g05 and name not like @g06 and name not like @g07 and name not like @g08 and name not like @g09 and name not like @g10 order by name", new { green, y1, y2, y3, y4, y5, g01, g02, g03, g04, g05, g06, g07, g08, g09, g10 });

        //    //do something with linq here, return ienumerable of type word, don't need idbconnection
        //    //var foo = wordleanswers.select(x => x);
        //    var foo = wordleanswers.where(word => word.contains(green));
        //    //var foo = from x in wordleanswers
        //    //          where x.contains(green) 
        //    //          && x.contains(y1) && x.contains(y2) && x.contains(y3) && x.contains(y4) && x.contains(y5)
        //    //          && !x.contains(g01) && !x.contains(g02) && !x.contains(g03) && !x.contains(g04) && !x.contains(g05)
        //    //          && !x.contains(g06) && !x.contains(g07) && !x.contains(g08) && !x.contains(g09) && !x.contains(g10)
        //    //          orderby x
        //    //          select x;
        //    return foo;
        //}
        public IEnumerable<string> GetResults2(string gn1, string gn2, string gn3, string gn4, string gn5, string y1, string y2, string y3, string y4, string y5, string g01, string g02, string g03, string g04, string g05, string g06, string g07, string g08, string g09, string g10)
        {
            //return _conn.Query<Word>("SELECT * FROM words WHERE Name LIKE @green AND Name LIKE @y1 AND Name LIKE @y2 AND Name LIKE @y3 AND Name LIKE @y4 AND Name LIKE @y5 AND Name NOT LIKE @g01 AND Name NOT LIKE @g02 AND Name NOT LIKE @g03 AND Name NOT LIKE @g04 AND Name NOT LIKE @g05 AND Name NOT LIKE @g06 AND Name NOT LIKE @g07 AND Name NOT LIKE @g08 AND Name NOT LIKE @g09 AND Name NOT LIKE @g10 ORDER BY Name", new { green, y1, y2, y3, y4, y5, g01, g02, g03, g04, g05, g06, g07, g08, g09, g10 });

            //do something with linq here, return IEnumerable of type word, don't need IDbConnection
            //var foo = WordleAnswers.Select(x => x);
            if (gn1 is null)
            {
                gn1 = ".";
            }
            if (gn2 is null)
            {
                gn2 = ".";
            }
            if (gn3 is null)
            {
                gn3 = ".";
            }
            if (gn4 is null)
            {
                gn4 = ".";
            }
            if (gn5 is null)
            {
                gn5 = ".";
            }

            Regex regex = new Regex($"{gn1}{gn2}{gn3}{gn4}{gn5}");

            var foo = Answer.WordleAnswers.Where(word => regex.IsMatch(word));

            //var foo = WordleAnswers.Where(word => word[0].ToString() == gn1 && word[1].ToString() == gn2);
            //var foo = from word in WordleAnswers
            //          where word[0].ToString() == gn1 &&
            //                word[1].ToString() == gn2 &&
            //                word[2].ToString() == gn3 &&
            //                word[3].ToString() == gn4 &&
            //                word[4].ToString() == gn5
            //          select word;
            //var foo = from x in WordleAnswers
            //          where x.Contains(green) 
            //          && x.Contains(y1) && x.Contains(y2) && x.Contains(y3) && x.Contains(y4) && x.Contains(y5)
            //          && !x.Contains(g01) && !x.Contains(g02) && !x.Contains(g03) && !x.Contains(g04) && !x.Contains(g05)
            //          && !x.Contains(g06) && !x.Contains(g07) && !x.Contains(g08) && !x.Contains(g09) && !x.Contains(g10)
            //          orderby x
            //          select x;
            return foo;
        }
    }
}
