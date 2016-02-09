﻿using PropertyManager.Api.Domain;
using System.Data.Entity;

namespace PropertyManager.Api.Infrastructure
{
    public class PropertyManagerDataContext : DbContext
    {
        public PropertyManagerDataContext() : base("Property Manager")
        {
        }

        public IDbSet<Address> Addresses { get; set; }
        public IDbSet<Lease> Leases { get; set; }
        public IDbSet<Property> Properties { get; set; }
        public IDbSet<Tenant> Tenants { get; set; }
        public IDbSet<WorkOrder> WorkOrders { get; set; }

        //Model our relationships
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Address
            modelBuilder.Entity<Address>()
            .HasMany(a => a.Properties)
            .WithRequired(p => p.Address)
            .HasForeignKey(p => p.AddressId);

            modelBuilder.Entity<Address>()
            .HasMany(a => a.Tenants)
            .WithRequired(t => t.Address)
            .HasForeignKey(t => t.AddressId)
            .WillCascadeOnDelete(false);

            //Leases
            //There are so many relationships here, so we'll move on

            //Property

            modelBuilder.Entity<Property>()
            .HasMany(p => p.Leases)
            .WithRequired(l => l.Property)
            .HasForeignKey(l => l.PropertyId);

            modelBuilder.Entity<Property>()
        .HasMany(p => p.WorkOrders)
        .WithRequired(wo => wo.Property)
        .HasForeignKey(wo => wo.PropertyId);

            //Tenant

            modelBuilder.Entity<Tenant>()
             .HasMany(t => t.Leases)
            .WithRequired(l => l.Tenant)
            .HasForeignKey(l => l.TenantId);

            modelBuilder.Entity<Tenant>()
            .HasMany(t => t.WorkOrders)
            .WithRequired(wo => wo.Tenant)
            .HasForeignKey(wo => wo.TenantId);
        }
    }
}
