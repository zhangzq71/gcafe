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
    
    public partial class credit
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public Nullable<int> member_id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public Nullable<System.DateTime> repay_time { get; set; }
    
        public virtual member member { get; set; }
        public virtual order order { get; set; }
    }
}
