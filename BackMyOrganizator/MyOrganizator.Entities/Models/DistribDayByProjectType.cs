using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Entities.Models
{
    public partial class DistribDayByProjectType
    {
        public DistribDayByProjectType()
        {
            DistribDayByProjects = new HashSet<DistribDayByProject>();
            ProjectTypes = new HashSet<ProjectType>();
        }

        public long DistribDayByProjectTypeId { get; set; }
        public int Percentage { get; set; }
        public int State { get; set; }

        public virtual ICollection<DistribDayByProject> DistribDayByProjects { get; set; }
        public virtual ICollection<ProjectType> ProjectTypes { get; set; }
    }
}
