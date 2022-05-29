using System.Collections.Generic;
using WordAssistant.Models;

namespace WordAssistant
{
    public interface IGuessService
    {
        public IEnumerable<string> GetResults(string gn1, string gn2, string gn3, string gn4, string gn5, string y1, string y2, string y3, string y4, string y5, string g01, string g02, string g03, string g04, string g05, string g06, string g07, string g08, string g09, string g10);
    }
}
