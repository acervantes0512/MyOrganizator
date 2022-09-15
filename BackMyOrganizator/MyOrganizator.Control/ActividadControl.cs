using MyOrganizator.Data;
using MyOrganizator.Entities.Models.Request;
using MyOrganizator.Modelo.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Control
{
  public class ActividadControl
  {

    DatosActividades datosActividad= new DatosActividades();

    public void CrearActividad(RequestCrearActividad peticion)
    {
      datosActividad.crearActividad(mapearDatosPeticion(peticion));
    }

    private PlanActividad mapearDatosPeticion(RequestCrearActividad peticion)
    {
      PlanActividad p = new PlanActividad();
      p.Nombre = peticion.NombreActividad;
      p.Descripcion = peticion.Descripcion;
      p.DuracionMinutos = Convert.ToInt32(peticion.DuracionMinutos);
      p.FechaInicio = Convert.ToDateTime(peticion.FechaInicio);
      p.FechaFin = Convert.ToDateTime(peticion.FechaFin);
      p.TipoActividadId = Convert.ToInt32(peticion.IdTipoActividad);
      p.TipoTiempoId = Convert.ToInt32(peticion.IdTipoTiempo);
      p.ProyectoId = Convert.ToInt32(peticion.IdProyecto);

      return p;
    }

    public void EditarActividad(RequestEditarActividad peticion)
    {
      datosActividad.editarActividad(mapearDatosEditarPeticion(peticion));
    }

    private PlanActividad mapearDatosEditarPeticion(RequestEditarActividad peticion)
    {
      PlanActividad p = new PlanActividad();
      p.PlanActividadId = peticion.ActividadId;
      p.Nombre = peticion.NombreActividad;
      p.Descripcion = peticion.Descripcion;
      p.DuracionMinutos = peticion.DuracionMinutos;
      p.FechaInicio = Convert.ToDateTime(peticion.FechaInicio);
      p.FechaFin = Convert.ToDateTime(peticion.FechaFin);
      p.TipoActividadId = Convert.ToInt32(peticion.IdTipoActividad);
      p.TipoTiempoId = Convert.ToInt32(peticion.IdTipoTiempo);
      p.ProyectoId = Convert.ToInt32(peticion.IdProyecto);

      return p;
    }

    public void eliminarActividad(int actividadId)
    {
      datosActividad.eliminarActividad(actividadId);
    }

  }
}
