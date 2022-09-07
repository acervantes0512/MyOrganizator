using MyOrganizator.Data;
using MyOrganizator.Data.Modelo;
using MyOrganizator.Entities.Models;
using MyOrganizator.Entities.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Control
{
  public class ProjectControl
  {

    DatosProyecto datosProyecto = new DatosProyecto();
    DatosUsuario datosUsuario = new DatosUsuario();
    DatosActividades datosActividades = new DatosActividades();

    public ProjectControl()
    {

    }

    /// <summary>
    /// método usado solo para pruebas del front
    /// </summary>
    /// <returns></returns>
    public List<Proyecto> getAllProjects(string nombreUsuario)
    {
      return datosProyecto.ProyectosPorIdUsuario(datosUsuario.ObtenerUsuarioPorUsername(nombreUsuario).IdUsuario);
    }

    public Proyecto obtenerProyectoPorId(string idProyecto)
    {
      return datosProyecto.obtenerProyectoPorId(idProyecto);
    }

    public List<PlanActividad> obtenerActividadesPorProyecto(int idProyecto)
    {
      return datosActividades.obtenerActividadesPorProyecto(idProyecto);
    }

    public void crearProyecto(RequestCrearProyecto nuevoProyecto)
    {
      this.datosProyecto.crearProyecto(convertirPeticionCrear(nuevoProyecto));
    }

    private Proyecto convertirPeticionCrear(RequestCrearProyecto nuevoProyecto)
    {
      Proyecto p = new Proyecto();

      p.Nombre = nuevoProyecto.nombreProyecto;
      p.Descripcion = nuevoProyecto.descripcionProyecto;
      p.DuracionMinutos = 5000;
      p.FechaCreacion = DateTime.Now;
      p.FechaInicio = Convert.ToDateTime(nuevoProyecto.fechaInicio);
      p.FechaFin = Convert.ToDateTime(nuevoProyecto.fechaFin); //TODO Calcular fecha fin
      p.IdAsignacionProyecto = 1; //TODO consultar el id
      p.IdTipoProyecto = Convert.ToInt32(nuevoProyecto.tipoProyecto);
      p.IdUsuario = this.datosUsuario.ObtenerUsuarioPorUsername(nuevoProyecto.usuario).IdUsuario;
      p.Etiqueta = nuevoProyecto.etiquetas;
      p.Estado = true;

      return p;

    }

    private Proyecto convertirPeticionEditar(RequestEditarProyecto editarProyecto)
    {
      Proyecto p = new Proyecto();

      p.IdProyecto = editarProyecto.idProyecto;
      p.Nombre = editarProyecto.nombreProyecto;
      p.Descripcion = editarProyecto.descripcionProyecto;
      p.DuracionMinutos = 5000;
      p.FechaCreacion = DateTime.Now;
      p.FechaInicio = Convert.ToDateTime(editarProyecto.fechaInicio);
      p.FechaFin = Convert.ToDateTime(editarProyecto.fechaFin); //TODO Calcular fecha fin
      p.IdAsignacionProyecto = 1; //TODO consultar el id
      p.IdTipoProyecto = editarProyecto.tipoProyecto;
      p.IdUsuario = this.datosUsuario.ObtenerUsuarioPorUsername(editarProyecto.usuario).IdUsuario;
      p.Etiqueta = editarProyecto.etiquetas;
      p.Estado = true;

      return p;

    }

    public void eliminarProyecto(int idProyecto)
    {
      this.datosProyecto.eliminarProyecto(idProyecto);
    }

    public void actualizarProyecto(RequestEditarProyecto peticionActualizar)
    {
      this.datosProyecto.actualizarProyecto(this.convertirPeticionEditar(peticionActualizar));
    }

    }
  
}
