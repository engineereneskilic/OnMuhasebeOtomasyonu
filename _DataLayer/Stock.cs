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
    
    public partial class Stock
    {
        // Programımız çalıştığı anda nesneniyi ram ' çıkarmış ve private tanımlayarak dışarıdan erişilmesini engellemiş olduk
        private static Stock instance = new Stock();

        // Constructor Private olarak tanımlayarak new anahtar sözcüğü kullanılmasını engeliyoruz
        private Stock() { }
        // Oluşturduğunuz instace nesnemize dışarıdan erişilmesi için bir property tanımladık.
        public static Stock Instance
        {
            get
            {
                return instance;
            }
        }
        public int StockCode { get; set; }
        public Nullable<decimal> StockBarcode { get; set; }
        public string StockName { get; set; }
        public string StockComment { get; set; }
        public string StockType { get; set; }
        public Nullable<double> StockKDV { get; set; }
        public string StockMainUnitType { get; set; }
        public string StockSecondUnitType { get; set; }
        public string StockThirdUnitType { get; set; }
        public Nullable<int> StockMainUnit { get; set; }
        public Nullable<int> StockSecondUnit { get; set; }
        public Nullable<int> StockThirdUnit { get; set; }
        public string StockKDVSalesStatus { get; set; }
        public string StockKDVBuyingStatus { get; set; }
        public Nullable<double> StockMainUnitSalesPrice { get; set; }
        public Nullable<double> StockSecondUnitSalesPrice { get; set; }
        public Nullable<double> StockThirdUnitSalesPrice { get; set; }
        public Nullable<double> StockMainUnitBuyingPrice { get; set; }
        public Nullable<double> StockSecondUnitBuyingPrice { get; set; }
        public Nullable<double> StockThirdUnitBuyingPrice { get; set; }
    }
}
