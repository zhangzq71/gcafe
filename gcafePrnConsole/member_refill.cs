//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gcafePrnConsole
{
    using System;
    using System.Collections.Generic;
    
    public partial class member_refill
    {
        public int id { get; set; }
        public int branch_id { get; set; }
        public int member_id { get; set; }
        public decimal refill_amount { get; set; }
        public int staff_id { get; set; }
        public System.DateTime refill_time { get; set; }
    
        public virtual branch branch { get; set; }
        public virtual member member { get; set; }
        public virtual staff staff { get; set; }
    }
}
