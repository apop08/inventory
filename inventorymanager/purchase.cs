//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace inventorymanager
{
    using System;
    using System.Collections.Generic;
    
    public partial class purchase
    {
        public int purchaseid { get; set; }
        public int itemid { get; set; }
        public int storeid { get; set; }
        public int purchase_qty { get; set; }
        public int totalpurchase { get; set; }
        public int workerid { get; set; }
    
        public virtual item item { get; set; }
        public virtual storeid storeid1 { get; set; }
        public virtual worker worker { get; set; }
    }
}
