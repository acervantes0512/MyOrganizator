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

    public void editarActividad(PlanActividad actividadEditada)
    {
      var entity = contextoBD.PlanActividads.Find(actividadEditada.PlanActividadId);

      entity.Nombre = actividadEditada.Nombre;
      entity.OrdenEjecucion = actividadEditada.OrdenEjecucion;
      entity.ProyectoId = actividadEditada.ProyectoId;
      entity.TipoActividadId = actividadEditada.TipoActividadId;
      entity.FechaInicio = actividadEditada.FechaInicio;
      entity.FechaFin = actividadEditada.FechaFin;
      entity.DuracionMinutos = actividadEditada.DuracionMinutos;
      entity.Descripcion = actividadEditada.Descripcion;

      contextoBD.PlanActividads.Update(entity);
      contextoBD.SaveChanges();
    }

    public void eliminarActividad(int idActividad)
    {
      var obj = contextoBD.PlanActividads.Find(idActividad);
      contextoBD.PlanActividads.Remove(obj);
      contextoBD.SaveChanges();
    }

  }
}
