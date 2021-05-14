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
      p.Name = "Venta Online";
      p.Description = "Esta es la descripción del proyecto uno, esta es solamente un texto para el ejemplo de la descripción. ";
      p.State = 1;
      p.Label = "Trabajo";
      p.RegisterDate = Convert.ToDateTime("01/03/2021");
      p.StartDate = Convert.ToDateTime("05/05/2021");
      p.EndDate = Convert.ToDateTime("29/05/2021");
      p.ProjectId = 1;
      p.ProjectTypeId = 1;

      this.myProjects.Add(p);

      Project p1 = new Project();

      p1.ProjectId = 2;
      p1.Name = "My Organizator";
      p1.Description = "Proyecto personal construido para la agenda diaria personal y el seguimiento de la productividad";
      p1.State = 1;
      p1.Label = "Personal";
      p1.RegisterDate = Convert.ToDateTime("03/03/2021");
      p1.StartDate = Convert.ToDateTime("02/04/2021");
      p1.EndDate = Convert.ToDateTime("15/06/2021");
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
