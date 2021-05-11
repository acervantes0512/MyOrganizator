using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Entities.Models
{
    public partial class RealTime
    {
        public long RealTimeId { get; set; }
        public DateTime RegisterDate { get; set; }
        public decimal WorkMinutes { get; set; }
        public long ActivityPlanId { get; set; }

        public virtual ActivitiesPlan RealTimeNavigation { get; set; }
    }
}
