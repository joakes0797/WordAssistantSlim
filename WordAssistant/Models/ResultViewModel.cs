using System.Collections.Generic;

namespace WordAssistant.Models
{
    public class ResultViewModel
    {
        public string TableHeadMessage { get; set; }
        public IEnumerable<string> Words { get; set; }
    }
}
