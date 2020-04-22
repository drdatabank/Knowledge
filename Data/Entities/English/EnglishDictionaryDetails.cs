using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knowledge.Data.Entities.English
{
    public class EnglishDictionaryDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EnglishDictionaryDetails()
        {
            this.EnglishDictionaryDetails_EnglishWordsList = new HashSet<EnglishDictionaryDetails_EnglishWordsList>();
        }

        public int Id { get; set; }
        public Nullable<int> EnglishWordsListId { get; set; }
        public Nullable<int> CorrectAnswersCount { get; set; }
        public Nullable<int> WrongAnswersCount { get; set; }
        public Nullable<int> EnglishWordsGroupId { get; set; }
        public Nullable<System.DateTime> ModificationDate { get; set; }
        public string UserId { get; set; }
        public Nullable<int> CorrectWrittenCount { get; set; }
        public Nullable<int> WrongWrittenCount { get; set; }
        public string Note { get; set; }

        public virtual EnglishDictionary EnglishDictionary { get; set; }
        public virtual EnglishWordsGroup EnglishWordsGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnglishDictionaryDetails_EnglishWordsList> EnglishDictionaryDetails_EnglishWordsList { get; set; }
    }
}
