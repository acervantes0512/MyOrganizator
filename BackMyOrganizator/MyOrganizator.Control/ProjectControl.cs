using MyOrganizator.Data;
using MyOrganizator.Data.Modelo;
using MyOrganizator.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Control
{
  public class ProjectControl
  {

    List<Project> myProjects = new List<Project>();
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

    public void crearProyecto(Proyecto nuevoProyecto)
    {
      this.datosProyecto.crearProyecto(nuevoProyecto);
    }

    }
  
}
