//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesTransactionInvoice
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public int Invoice_ID { get; set; }
        public decimal Invoice_TOTAL { get; set; }
        public System.DateTime Invoice_DATE { get; set; }
        public int Customer_ID { get; set; }
        public string Invoice_NUMBER { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
