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
    
    public partial class printer_group
    {
        public printer_group()
        {
            this.menu = new HashSet<menu>();
            this.printer = new HashSet<printer>();
        }
    
        public int id { get; set; }
        public int branch_id { get; set; }
        public string name { get; set; }
        public int print_cnt { get; set; }
        public int print_total_cnt { get; set; }
    
        public virtual branch branch { get; set; }
        public virtual ICollection<menu> menu { get; set; }
        public virtual ICollection<printer> printer { get; set; }
    }
}
