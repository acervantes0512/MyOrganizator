using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Entities.Models
{
    public partial class TimeType
    {
        public TimeType()
        {
            ActivitiesPlans = new HashSet<ActivitiesPlan>();
        }

        public long TimeTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ActivitiesPlan> ActivitiesPlans { get; set; }
    }
}
