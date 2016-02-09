﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManager.Api.Models
{
    public class LeaseModel
    {
        public enum RentFrequencies
        {
            Daily = 1,
            Weekly = 2,
            Monthly = 3,
            Quarterly = 4,
            BiAnnually = 5,
            Annually = 6
        }
        public class Lease
        {
            //Properties
            public int LeaseId { get; set; }
            public int TenantId { get; set; }
            public int? PropertyId { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public decimal RentAmount { get; set; }
            public RentFrequencies RentFrequency { get; set; }
        }
    }
}