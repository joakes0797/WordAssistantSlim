using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using WordAssistant.Models;

namespace WordAssistant
{
    public class GuessService : IGuessService
    {
        public IEnumerable<string> GetResults(string gn1, string gn2, string gn3, string gn4, string gn5, string y1, string y2, string y3, string y4, string y5, string g01, string g02, string g03, string g04, string g05, string g06, string g07, string g08, string g09, string g10)
        {
            //------------------------------------------------- green letters
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
            //------------------------------------------------- yellow letters
            if (y1 is null)
            {
                y1 = ".";
            }
            if (y2 is null)
            {
                y2 = ".";
            }
            if (y3 is null)
            {
                y3 = ".";
            }
            if (y4 is null)
            {
                y4 = ".";
            }
            if (y5 is null)
            {
                y5 = ".";
            }
            //------------------------------------------------- gray letters
            if (g01 is null)
            {
                g01 = "#";
            }
            if (g02 is null)
            {
                g02 = "#";
            }
            if (g03 is null)
            {
                g03 = "#";
            }
            if (g04 is null)
            {
                g04 = "#";
            }
            if (g05 is null)
            {
                g05 = "#";
            }
            if (g06 is null)
            {
                g06 = "#";
            }
            if (g07 is null)
            {
                g07 = "#";
            }
            if (g08 is null)
            {
                g08 = "#";
            }
            if (g09 is null)
            {
                g09 = "#";
            }
            if (g10 is null)
            {
                g10 = "#";
            }

            //---------------------------------------------------------------- green logic

            Regex regex = new Regex($"{gn1}{gn2}{gn3}{gn4}{gn5}");
            var foo = Answer.WordleAnswers.Where(word => regex.IsMatch(word));

            //---------------------------------------------------------------- yellow logic

            Regex regexY1 = new Regex($"{y1}");
            var foo2 = foo.Where(word => regexY1.IsMatch(word));

            Regex regexY2 = new Regex($"{y2}");
            var foo3 = foo2.Where(word => regexY2.IsMatch(word));

            Regex regexY3 = new Regex($"{y3}");
            var foo4 = foo3.Where(word => regexY3.IsMatch(word));

            Regex regexY4 = new Regex($"{y4}");
            var foo5 = foo4.Where(word => regexY4.IsMatch(word));

            Regex regexY5 = new Regex($"{y5}");
            var foo6 = foo5.Where(word => regexY5.IsMatch(word));

            //---------------------------------------------------------------- gray logic

            Regex regexG01 = new Regex($"{g01}");
            var foo7 = foo6.Where(word => !regexG01.IsMatch(word));

            Regex regexG02 = new Regex($"{g02}");
            var foo8 = foo7.Where(word => !regexG02.IsMatch(word));

            Regex regexG03 = new Regex($"{g03}");
            var foo9 = foo8.Where(word => !regexG03.IsMatch(word));

            Regex regexG04 = new Regex($"{g04}");
            var foo10 = foo9.Where(word => !regexG04.IsMatch(word));

            Regex regexG05 = new Regex($"{g05}");
            var foo11 = foo10.Where(word => !regexG05.IsMatch(word));

            Regex regexG06 = new Regex($"{g06}");
            var foo12 = foo11.Where(word => !regexG06.IsMatch(word));

            Regex regexG07 = new Regex($"{g07}");
            var foo13 = foo12.Where(word => !regexG07.IsMatch(word));

            Regex regexG08 = new Regex($"{g08}");
            var foo14 = foo13.Where(word => !regexG08.IsMatch(word));

            Regex regexG09 = new Regex($"{g09}");
            var foo15 = foo14.Where(word => !regexG09.IsMatch(word));

            Regex regexG10 = new Regex($"{g10}");
            var foo16 = foo15.Where(word => !regexG10.IsMatch(word));

            return foo16;
        }
    }
}
