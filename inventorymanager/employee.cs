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
    
    public partial class employee
    {
        public int employeenumber { get; set; }
        public int workerid { get; set; }
        public int storeid { get; set; }
    
        public virtual storelist storelist { get; set; }
        public virtual worker worker { get; set; }
    }
}
