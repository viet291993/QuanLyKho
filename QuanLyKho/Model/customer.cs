//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKho.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            this.outputs = new HashSet<output>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public sbyte gender { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<output> outputs { get; set; }
    }
}
