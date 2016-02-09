﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManager.Api.Models
{
    public class WorkOrderModel
    {
        public enum Priorities
        {
            Critical = 1,
            Major = 2,
            High = 3,
            Medium = 4,
            Low = 5
        }
        public class WorkOrder
        {
            public int WorkOrderId { get; set; }
            public int PropertyId { get; set; }
            public int TenantId { get; set; }
            public string Description { get; set; }
            public Priorities Priority { get; set; }
            public DateTime OpenedDate { get; set; }
            public DateTime ClosedDate { get; set; }
        }
    }
}