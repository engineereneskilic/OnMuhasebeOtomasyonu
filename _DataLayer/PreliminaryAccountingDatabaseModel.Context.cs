﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PreliminaryAccountingEntities : DbContext
    {
        public PreliminaryAccountingEntities()
            : base("name=PreliminaryAccountingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdressRegistry> AdressRegistry { get; set; }
        public virtual DbSet<CheckBonds> CheckBonds { get; set; }
        public virtual DbSet<Checks> Checks { get; set; }
        public virtual DbSet<Chest> Chest { get; set; }
        public virtual DbSet<ChestProcess> ChestProcess { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Missions> Missions { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Payrolls> Payrolls { get; set; }
        public virtual DbSet<RateList> RateList { get; set; }
        public virtual DbSet<RateTable> RateTable { get; set; }
        public virtual DbSet<Receipts> Receipts { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<BillDetail> BillDetail { get; set; }
        public virtual DbSet<Bills> Bills { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<StockMovements> StockMovements { get; set; }
        public virtual DbSet<CurrentCards> CurrentCards { get; set; }
        public virtual DbSet<CurrentCardDetails> CurrentCardDetails { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<BankTransfers> BankTransfers { get; set; }
        public virtual DbSet<BankProcess> BankProcess { get; set; }
        public virtual DbSet<AccountMovements> AccountMovements { get; set; }
    }
}