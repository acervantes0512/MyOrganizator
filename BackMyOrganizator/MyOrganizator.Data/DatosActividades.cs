using MyOrganizator.Modelo.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOrganizator.Data
{
  
  public class DatosActividades
  {
    private readonly TimeOrganizatorContext contextoBD = new TimeOrganizatorContext();

    public List<PlanActividad> obtenerActividadesPorProyecto(int idProyecto)
    {
      return contextoBD.PlanActividads
        .Where(x => x.Proyecto.ProyectoId == idProyecto).ToList();
    }

    public void crearActividad(PlanActividad nuevaActividad)
    {
      contextoBD.Set<PlanActividad>().Add(nuevaActividad);
      contextoBD.SaveChanges();
    }

  }
}
