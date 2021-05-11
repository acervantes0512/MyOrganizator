using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Entities.Models
{
    public partial class DistribDayByProject
    {
        public long DistribDayByProjectId { get; set; }
        public long DistProjectTypeId { get; set; }
        public int Percentaje { get; set; }
        public int State { get; set; }

        public virtual DistribDayByProjectType DistProjectType { get; set; }
    }
}
