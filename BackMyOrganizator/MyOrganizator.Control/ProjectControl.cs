using MyOrganizator.Data;
using MyOrganizator.Entities.Models;
using MyOrganizator.Entities.Models.Request;
using MyOrganizator.Modelo.Tables;
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
      return datosProyecto.ProyectosPorIdUsuario(datosUsuario.ObtenerUsuarioPorUsername(nombreUsuario).UsuarioId);
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
      p.AsignacionProyectoId = 1; //TODO consultar el id
      p.TipoProyectoId = Convert.ToInt32(nuevoProyecto.tipoProyecto);
      p.UsuarioId = this.datosUsuario.ObtenerUsuarioPorUsername(nuevoProyecto.usuario).UsuarioId;
      p.Etiqueta = nuevoProyecto.etiquetas;
      p.Estado = true;

      return p;

    }

    private Proyecto convertirPeticionEditar(RequestEditarProyecto editarProyecto)
    {
      Proyecto p = new Proyecto();

      p.ProyectoId = editarProyecto.ProyectoId;
      p.Nombre = editarProyecto.nombreProyecto;
      p.Descripcion = editarProyecto.descripcionProyecto;
      p.DuracionMinutos = 5000;
      p.FechaCreacion = DateTime.Now;
      p.FechaInicio = Convert.ToDateTime(editarProyecto.fechaInicio);
      p.FechaFin = Convert.ToDateTime(editarProyecto.fechaFin); //TODO Calcular fecha fin
      p.AsignacionProyectoId = 1; //TODO consultar el id
      p.TipoProyectoId = editarProyecto.tipoProyecto;
      p.UsuarioId = this.datosUsuario.ObtenerUsuarioPorUsername(editarProyecto.usuario).UsuarioId;
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
