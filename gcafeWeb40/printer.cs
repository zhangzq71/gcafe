//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gcafeWeb40
{
    using System;
    using System.Collections.Generic;
    
    public partial class printer
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> printer_group_id { get; set; }
        public int print_cnt { get; set; }
        public int print_total_cnt { get; set; }
    
        public virtual printer_group printer_group { get; set; }
    }
}