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
    
    public partial class InvoiceItem
    {
        public long ID { get; set; }
        public long InvoiceID { get; set; }
        public long ProductID { get; set; }
        public int Quantity { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
