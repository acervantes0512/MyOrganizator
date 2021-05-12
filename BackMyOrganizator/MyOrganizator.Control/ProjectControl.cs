using MyOrganizator.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Control
{
  public class ProjectControl
  {

    List<Project> myProjects = new List<Project>();

    public ProjectControl()
    {

    }

    /// <summary>
    /// método usado solo para pruebas del front
    /// </summary>
    /// <returns></returns>
    public List<Project> getAllProjects()
    {
      if(this.myProjects.Count == 0)
      {
        this.initializeProjects();
      }
      return this.myProjects;
    }

    private void initializeProjects()
    {
      Project p = new Project();

      p.ProjectId = 1;
      p.Name = "Proyecto 1";
      p.Description = "Esta es la descripción del proyecto uno, esta es solamente un texto para el ejemplo de la descripción. ";
      p.State = 1;
      p.Label = "Personal";
      p.RegisterDate = Convert.ToDateTime("11/05/2021");
      p.StartDate = Convert.ToDateTime("11/05/2021");
      p.EndDate = Convert.ToDateTime("11/05/2021");
      p.ProjectId = 1;
      p.ProjectTypeId = 1;

      this.myProjects.Add(p);

      Project p1 = new Project();

      p1.ProjectId = 2;
      p1.Name = "Proyecto 2";
      p1.Description = "Descripción proyecto 2 Descripción proyecto 1 Descripción proyecto 2";
      p1.State = 1;
      p1.Label = "Trabajo";
      p1.RegisterDate = Convert.ToDateTime("11/05/2021");
      p1.StartDate = Convert.ToDateTime("11/05/2021");
      p1.EndDate = Convert.ToDateTime("11/05/2021");
      p1.ProjectId = 2;
      p1.ProjectTypeId = 2;

      this.myProjects.Add(p1);



      /*public DateTime RegisterDate { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public long ProjectTypeId { get; set; }
      public long DistDayProjectId { get; set; }

      public virtual ProjectType ProjectType { get; set; }
      public virtual ICollection<ActivitiesPlan> ActivitiesPlans { get; set; }*/
    }

  }
}
