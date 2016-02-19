using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PropertyManager.Api.Models;
using System.Collections.ObjectModel;

namespace PropertyManager.Api.Domain
{
    public class Tenant
    {
        public Tenant()
        {
            Leases = new Collection<Lease>();
            WorkOrders = new Collection<WorkOrder>();
        }
        public Tenant(TenantModel tenant)
        {
            Update(tenant);
        }

        public int TenantId { get; set; }
        public string UserId { get; set; }

        public int? AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string EmailAddress { get; set; }

        public virtual Address Address { get; set; }

        public virtual PropertyManagerUser User { get; set; }

        public virtual ICollection<Lease> Leases { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }

        public void Update(TenantModel tenant)
        {
            FirstName = tenant.FirstName;
            LastName = tenant.LastName;
            Telephone = tenant.Telephone;
            EmailAddress = tenant.EmailAddress;

            Address.Update(tenant.Address);
        }
    }
}
