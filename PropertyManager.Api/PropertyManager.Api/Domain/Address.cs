﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PropertyManager.Api.Models;

namespace PropertyManager.Api.Domain
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public bool International { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
        public virtual ICollection<Tenant> Tenants { get; set; }

        public void Update(AddressModel modelAddress)
        {
            Address1 = modelAddress.Address1;
            Address2 = modelAddress.Address2;
            Address3 = modelAddress.Address3;
            Address4 = modelAddress.Address4;
            Address5 = modelAddress.Address5;
            City = modelAddress.City;
            State = modelAddress.State;
            PostCode = modelAddress.PostCode;
            International = modelAddress.International;
        }
    }
}