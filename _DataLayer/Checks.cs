//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Checks
    {
        public int CheckNo { get; set; }
        public Nullable<System.DateTime> IssuedDate { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string DebtorCurrentName { get; set; }
        public Nullable<decimal> NetDebt { get; set; }
        public Nullable<decimal> NetCredit { get; set; }
        public string Currency { get; set; }
        public string TransferredCurrentName { get; set; }
        public string Statuss { get; set; }
        public string Confirmation { get; set; }
    }
}