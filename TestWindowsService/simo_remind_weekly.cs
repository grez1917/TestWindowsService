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
    
    public partial class simo_remind_weekly
    {
        public int id_weekly { get; set; }
        public Nullable<int> id { get; set; }
        public bool senin { get; set; }
        public bool selasa { get; set; }
        public bool rabu { get; set; }
        public bool kamis { get; set; }
        public bool jumat { get; set; }
        public bool sabtu { get; set; }
        public bool on_off { get; set; }
    
        public virtual simo simo { get; set; }
    }
}