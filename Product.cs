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
    
    public partial class Product
    {
        public Product()
        {
            this.InvoiceItems = new HashSet<InvoiceItem>();
            this.Prices = new HashSet<Price>();
        }
    
        public long ID { get; set; }
        public long CompanyID { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
    }
}
