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
    
    public partial class simo_detail_berkas_deskripsi
    {
        public int Id_berkas { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public Nullable<int> id_detail_berkas { get; set; }
    
        public virtual simo_detail_berkas simo_detail_berkas { get; set; }
    }
}
