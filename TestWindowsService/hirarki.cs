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
    
    public partial class hirarki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hirarki()
        {
            this.UserRoles = new HashSet<UserRole>();
            this.hirarki1 = new HashSet<hirarki>();
            this.Users = new HashSet<User>();
        }
    
        public int id_hirarki { get; set; }
        public string level { get; set; }
        public Nullable<int> level_parent { get; set; }
        public bool non_overdue { get; set; }
        public bool overdue1_30 { get; set; }
        public bool overdue30_ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRole> UserRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hirarki> hirarki1 { get; set; }
        public virtual hirarki hirarki2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
