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
    
    public partial class simo_remind_date
    {
        public int id_one_time { get; set; }
        public Nullable<int> id { get; set; }
        public Nullable<System.DateTime> tanggal { get; set; }
        public bool on_off { get; set; }
    
        public virtual simo simo { get; set; }
    }
}
