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
    
    public partial class CurrentCards
    {
        // Programımız çalıştığı anda nesneniyi ram ' çıkarmış ve private tanımlayarak dışarıdan erişilmesini engellemiş olduk
        private static CurrentCards instance = new CurrentCards();

        // Constructor Private olarak tanımlayarak new anahtar sözcüğü kullanılmasını engeliyoruz
        private CurrentCards() { }
        // Oluşturduğunuz instace nesnemize dışarıdan erişilmesi için bir property tanımladık.
        public static CurrentCards Instance
        {
            get
            {
                return instance;
            }
        }
        public string CurrentType { get; set; }
        public int CurrentCode { get; set; }
        public string CurrentName { get; set; }
        public Nullable<double> BalanceDebt { get; set; }
        public Nullable<double> BalanceCredit { get; set; }
        public string Currency { get; set; }
    }
}
