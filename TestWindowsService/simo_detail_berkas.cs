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
    
    public partial class simo_detail_berkas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public simo_detail_berkas()
        {
            this.simo_detail_berkas_deskripsi = new HashSet<simo_detail_berkas_deskripsi>();
        }
    
        public int id_detail_berkas { get; set; }
        public Nullable<System.DateTime> waktu_simpan { get; set; }
        public string berkas { get; set; }
        public Nullable<int> id_detail { get; set; }
        public string progress { get; set; }
        public string modify_by { get; set; }
    
        public virtual simo_detail simo_detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<simo_detail_berkas_deskripsi> simo_detail_berkas_deskripsi { get; set; }
    }
}