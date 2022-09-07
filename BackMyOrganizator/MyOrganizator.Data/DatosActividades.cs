using MyOrganizator.Data.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOrganizator.Data
{
  
  public class DatosActividades
  {
    private readonly MyOrganizatorContext contextoBD = new MyOrganizatorContext();

    public List<PlanActividad> obtenerActividadesPorProyecto(int idProyecto)
    {
      /*return contextoBD.PlanActividads
        .Where(x => x.IdProyecto == idProyecto).ToList();*/
      return null;
    }

    public void crearActividad(PlanActividad nuevaActividad)
    {
      contextoBD.Set<PlanActividad>().Add(nuevaActividad);
      contextoBD.SaveChanges();
    }

  }
}
