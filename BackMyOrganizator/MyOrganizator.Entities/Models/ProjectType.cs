using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Entities.Models
{
    public partial class ProjectType
    {
        public ProjectType()
        {
            ActivityTypes = new HashSet<ActivityType>();
            Projects = new HashSet<Project>();
        }

        public long ProjectTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public long DistProjectTypeId { get; set; }

        public virtual DistribDayByProjectType DistProjectType { get; set; }
        public virtual ICollection<ActivityType> ActivityTypes { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
