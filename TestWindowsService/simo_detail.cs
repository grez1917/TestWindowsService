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
    
    public partial class simo_detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public simo_detail()
        {
            this.simo_detail_pic = new HashSet<simo_detail_pic>();
            this.simo_detail_berkas = new HashSet<simo_detail_berkas>();
        }
    
        public int id_detail { get; set; }
        public Nullable<int> id { get; set; }
        public string tema { get; set; }
        public string deskripsi { get; set; }
        public string divisi { get; set; }
        public string pic { get; set; }
        public Nullable<System.DateTime> deadline { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<System.DateTime> last_update { get; set; }
        public Nullable<bool> is_close { get; set; }
    
        public virtual simo simo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<simo_detail_pic> simo_detail_pic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<simo_detail_berkas> simo_detail_berkas { get; set; }
        public virtual status status1 { get; set; }
    }
}
