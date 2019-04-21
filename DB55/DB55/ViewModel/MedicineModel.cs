using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB55.ViewModel
{
    public class MedicineModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Disease> Diseases { get; set; }
    }
}