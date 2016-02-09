﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PropertyManager.Api.Models;

namespace PropertyManager.Api.Domain
{
    public enum RentFrequencies
    {
        Daily = 1,
        Weekly = 2,
        Monthy = 3,
        Quarterly = 4,
        BiAnnually = 5,
        Annually = 6
    }
    public class Lease
    {
        public int LeaseId { get; set; }
        public int TenantId { get; set; }
        public int PropertyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal RentAmount { get; set; }
        public RentFrequencies RentFrequency { get; set; }

        public virtual Property Property { get; set; }
        public virtual Tenant Tenant { get; set; }

        public void Update(LeaseModel lease)
        {
            TenantId = lease.TenantId;
            PropertyId = lease.PropertyId;
            StartDate = lease.StartDate;
            EndDate = lease.EndDate;
            RentAmount = lease.RentAmount;
            RentFrequency = lease.RentFrequency;
        }
    }
}
