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
    
    public partial class Price
    {
        public long ID { get; set; }
        public long ProductID { get; set; }
        public System.DateTime Date { get; set; }
        public int Buy { get; set; }
        public int Sell { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
