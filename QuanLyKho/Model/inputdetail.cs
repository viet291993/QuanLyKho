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
    
    public partial class inputdetail
    {
        public int quantity { get; set; }
        public int price { get; set; }
        public int amount { get; set; }
        public long input_id { get; set; }
        public int products_id { get; set; }
    
        public virtual input input { get; set; }
        public virtual product product { get; set; }
    }
}
