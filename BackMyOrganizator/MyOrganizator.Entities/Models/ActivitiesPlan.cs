using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Entities.Models
{
    public partial class ActivitiesPlan
    {
        public long ActivitiesPlanId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal EstimatedMinutes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int OrderExecution { get; set; }
        public long TimeTypeId { get; set; }
        public long TypeActivityId { get; set; }
        public long ProjectId { get; set; }

        public virtual Project Project { get; set; }
        public virtual TimeType TimeType { get; set; }
        public virtual ActivityType TypeActivity { get; set; }
        public virtual RealTime RealTime { get; set; }
    }
}
