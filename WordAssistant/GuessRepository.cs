using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public static readonly List<string> WordleAnswers = new() { "cigar", "sissy", "debut" };
        //public GuessRepository()
        //{
        //    _answer = new Answer();
        //}
        
        public IEnumerable<string> GetResults(string green, string y1, string y2, string y3, string y4, string y5, string g01, string g02, string g03, string g04, string g05, string g06, string g07, string g08, string g09, string g10)
        {
            //return _conn.Query<Word>("SELECT * FROM words WHERE Name LIKE @green AND Name LIKE @y1 AND Name LIKE @y2 AND Name LIKE @y3 AND Name LIKE @y4 AND Name LIKE @y5 AND Name NOT LIKE @g01 AND Name NOT LIKE @g02 AND Name NOT LIKE @g03 AND Name NOT LIKE @g04 AND Name NOT LIKE @g05 AND Name NOT LIKE @g06 AND Name NOT LIKE @g07 AND Name NOT LIKE @g08 AND Name NOT LIKE @g09 AND Name NOT LIKE @g10 ORDER BY Name", new { green, y1, y2, y3, y4, y5, g01, g02, g03, g04, g05, g06, g07, g08, g09, g10 });
            
            //do something with linq here, return IEnumerable of type word, don't need IDbConnection
            var foo = WordleAnswers.Select(x => x);
            return foo;
        }
    }
}
