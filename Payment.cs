//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalExamApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public long ID { get; set; }
        public long CustomerID { get; set; }
        public long PayTypeID { get; set; }
        public System.DateTime Date { get; set; }
        public int Value { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual PayType PayType { get; set; }
    }
}
