using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Entities.Models
{
    public partial class ActivityType
    {
        public ActivityType()
        {
            ActivitiesPlans = new HashSet<ActivitiesPlan>();
        }

        public long ActivityTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long ProjectTypeId { get; set; }

        public virtual ProjectType ProjectType { get; set; }
        public virtual ICollection<ActivitiesPlan> ActivitiesPlans { get; set; }
    }
}
