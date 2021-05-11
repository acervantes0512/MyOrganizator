using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Entities.Models.Request
{
    public class ProjectRequest
    {

        public long ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string Label { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long ProjectTypeId { get; set; }
        public long DistDayProjectId { get; set; }

    }
}
