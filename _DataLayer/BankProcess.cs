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
    
    public partial class BankProcess
    {
        // Program�m�z �al��t��� anda nesneniyi ram ' ��karm�� ve private tan�mlayarak d��ar�dan eri�ilmesini engellemi� olduk
        private static BankProcess instance = new BankProcess();

        // Constructor Private olarak tan�mlayarak new anahtar s�zc��� kullan�lmas�n� engeliyoruz
        private BankProcess() { }
        // Olu�turdu�unuz instace nesnemize d��ar�dan eri�ilmesi i�in bir property tan�mlad�k.
        public static BankProcess Instance
        {
            get
            {
                return instance;
            }
        }
        public int BankProcessNo { get; set; }
        public Nullable<int> BankAccountNo { get; set; }
        public string ProcessType { get; set; }
        public Nullable<System.DateTime> ProcessDate { get; set; }
        public Nullable<int> CurrentCode { get; set; }
        public string CurrentName { get; set; }
        public string Descript { get; set; }
        public Nullable<double> NetCredit { get; set; }
        public Nullable<double> NetDebt { get; set; }
        public Nullable<double> Expense { get; set; }
        public string Currency { get; set; }
    }
}