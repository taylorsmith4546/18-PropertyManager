using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PropertyManager.Api.Models;
using System.Collections.ObjectModel;

namespace PropertyManager.Api.Domain
{
    public class Property
    {
        public Property()
        {
            Leases = new Collection<Lease>();
            WorkOrders = new Collection<WorkOrder>();
        }

        public Property(PropertyModel property)
        {
            Update(property);
        }

        public int PropertyId { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }

        public int? AddressId { get; set; }
        public string PropertyName { get; set; } //Strings can be null by default
        public int? SquareFeet { get; set; }  //Nullable: Can be empty or have a value
        public int? NumberOfBedrooms { get; set; }
        public float? NumberOfBathrooms { get; set; }
        public int? NumberOfVehicles { get; set; }
        public bool HasOutdoorSpace { get; set; }

        public virtual Address Address { get; set; }

        public virtual PropertyManagerUser User { get; set; }

        public virtual ICollection<Lease> Leases { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; } //virtual is keyowrd used for entity framework, 'lazy loading'

        public void Update(PropertyModel property)
        {
            PropertyName = property.PropertyName;
            SquareFeet = property.SquareFeet;
            NumberOfBedrooms = property.NumberOfBedrooms;
            NumberOfBathrooms = property.NumberOfBathrooms;
            NumberOfVehicles = property.NumberOfVehicles;
            HasOutdoorSpace = property.HasOutdoorSpace;
            Address.Update(property.Address);
        }
    }

}