//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace gcafeWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public order()
        {
            this.credit = new HashSet<credit>();
            this.order_detail = new HashSet<order_detail>();
        }
    
        public int id { get; set; }
        public int branch_id { get; set; }
        public string table_no { get; set; }
        public int open_table_staff_id { get; set; }
        public System.DateTime table_opened_time { get; set; }
        public Nullable<decimal> receivable { get; set; }
        public Nullable<decimal> net_receipts { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<int> discount_staff_id { get; set; }
        public Nullable<int> check_out_staff_id { get; set; }
        public Nullable<System.DateTime> check_out_time { get; set; }
        public Nullable<int> member_id { get; set; }
        public Nullable<int> shift_id { get; set; }
        public string memo { get; set; }
    
        public virtual branch branch { get; set; }
        public virtual ICollection<credit> credit { get; set; }
        public virtual member member { get; set; }
        public virtual staff staff { get; set; }
        public virtual staff staff1 { get; set; }
        public virtual ICollection<order_detail> order_detail { get; set; }
        public virtual shift shift { get; set; }
        public virtual staff staff2 { get; set; }
    }
}
