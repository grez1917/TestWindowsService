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
    
    public partial class buscon_sebab_akibat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public buscon_sebab_akibat()
        {
            this.buscon_progress = new HashSet<buscon_progress>();
        }
    
        public int id_sebab_akibat { get; set; }
        public string sebab { get; set; }
        public string akibat { get; set; }
        public string rekomendasi { get; set; }
        public string action_plant_mgmt { get; set; }
        public Nullable<System.DateTime> deadline { get; set; }
        public string risk { get; set; }
        public bool status_close { get; set; }
        public Nullable<int> pic { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<buscon_progress> buscon_progress { get; set; }
        public virtual User User { get; set; }
    }
}
