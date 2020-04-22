using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knowledge.Data.Entities.English
{
    public class EnglishDictionary
    {
        public int Id { get; set; }
        public string englishWord { get; set; }
        public string englishSentence { get; set; }
        public string englishSentence1 { get; set; }
        public string englishSentence2 { get; set; }
        public string polishWord { get; set; }
        public string polishSentence { get; set; }
        public string polishSentence1 { get; set; }
        public string polishSentence2 { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual EnglishDictionaryDetails EnglishDictionaryDetails { get; set; }
    }
}
