using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knowledge.Data.Entities.English
{
    public class EnglishWordsGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EnglishWordsGroup()
        {
            this.EnglishDictionaryDetails = new HashSet<EnglishDictionaryDetails>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnglishDictionaryDetails> EnglishDictionaryDetails { get; set; }
    }
}
