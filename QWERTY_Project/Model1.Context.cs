﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QWERTY_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class var1Entities : DbContext
    {
        public var1Entities()
            : base("name=var1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<DevicePart> DevicePart { get; set; }
        public virtual DbSet<FirstDiagnostic> FirstDiagnostic { get; set; }
        public virtual DbSet<PartsToRepair> PartsToRepair { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Repair> Repair { get; set; }
        public virtual DbSet<Specifications> Specifications { get; set; }
        public virtual DbSet<SpecificationsOfPart> SpecificationsOfPart { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }
    }
}
