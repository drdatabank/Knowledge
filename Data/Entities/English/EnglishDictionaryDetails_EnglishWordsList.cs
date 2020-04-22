using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knowledge.Data.Entities.English
{
    public class EnglishDictionaryDetails_EnglishWordsList
    {
        public int Id { get; set; }
        public Nullable<int> EnglishDictionaryDetailsId { get; set; }
        public Nullable<int> EnglishWordsListsId { get; set; }

        public virtual EnglishDictionaryDetails EnglishDictionaryDetails { get; set; }
        public virtual EnglishWordsLists EnglishWordsLists { get; set; }
    }
}
