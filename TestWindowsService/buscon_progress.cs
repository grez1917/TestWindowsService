//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWindowsService
{
    using System;
    using System.Collections.Generic;
    
    public partial class buscon_progress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public buscon_progress()
        {
            this.buscon_progress_berkas = new HashSet<buscon_progress_berkas>();
        }
    
        public int id_progress { get; set; }
        public Nullable<System.DateTime> tanggal { get; set; }
        public string progress { get; set; }
        public Nullable<System.DateTime> deadline { get; set; }
        public Nullable<int> modify_by { get; set; }
        public Nullable<int> id_sebab_akibat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<buscon_progress_berkas> buscon_progress_berkas { get; set; }
        public virtual User User { get; set; }
        public virtual buscon_sebab_akibat buscon_sebab_akibat { get; set; }
    }
}
