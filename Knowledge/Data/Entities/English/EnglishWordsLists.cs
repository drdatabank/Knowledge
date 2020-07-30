using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knowledge.Data.Entities.English
{
    public class EnglishWordsLists
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EnglishWordsLists()
        {
            this.EnglishDictionaryDetails_EnglishWordsList = new HashSet<EnglishDictionaryDetails_EnglishWordsList>();
        }

        public int Id { get; set; }
        public string ListName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnglishDictionaryDetails_EnglishWordsList> EnglishDictionaryDetails_EnglishWordsList { get; set; }
    }
}
