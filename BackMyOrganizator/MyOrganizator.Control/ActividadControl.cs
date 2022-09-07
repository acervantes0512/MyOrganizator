using MyOrganizator.Data;
using MyOrganizator.Data.Modelo;
using MyOrganizator.Entities.Models.Request;
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
      /*p.IdTipoActividad = Convert.ToInt32(peticion.IdTipoActividad);
      p.IdTipoTiempo = Convert.ToInt32(peticion.IdTipoTiempo);
      p.IdProyecto = Convert.ToInt32(peticion.IdProyecto);*/

      return p;
    }

  }
}
