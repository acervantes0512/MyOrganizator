using MyOrganizator.Data.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOrganizator.Data
{

  public class DatosProyecto
  {
    private readonly MyOrganizatorContext contextoBD = new MyOrganizatorContext();
    public List<Proyecto> ProyectosPorIdUsuario(int idUser)
    {
      List<Proyecto> rta = new List<Proyecto>();
      using (var context = new MyOrganizatorContext())
      {
        var proyecto = context.Proyectos
          .Where(p => p.IdUsuario == idUser && p.Estado).ToList();
        rta = proyecto;
      }

      return rta;
    }

    public Proyecto obtenerProyectoPorId(string idProyecto)
    {
      return contextoBD.Proyectos.Where(p => p.IdProyecto == Convert.ToInt32(idProyecto)).FirstOrDefault();          
    }

    public void crearProyecto(Proyecto nuevoProyecto)
    {
      contextoBD.Set<Proyecto>().Add(nuevoProyecto);
      contextoBD.SaveChanges();
    }

    public void eliminarProyecto(int idProyecto)
    {
      /*var obj = (from p in contextoBD.Proyectos
                   where p.IdProyecto == Convert.ToInt32(idProyecto)
                   select p).Single();*/
      Proyecto obj = contextoBD.Proyectos.Find(idProyecto);
      obj.Estado = false;
      contextoBD.Proyectos.Update(obj);
      contextoBD.SaveChanges();
    }

    public void actualizarProyecto(Proyecto proyectoModificado)
    {
      var entity = contextoBD.Proyectos.Find(proyectoModificado.IdProyecto);

      if(entity != null)
      {
        entity.IdTipoProyecto = proyectoModificado.IdTipoProyecto;
        entity.Nombre = proyectoModificado.Nombre;
        entity.Descripcion = proyectoModificado.Descripcion;
        entity.Etiqueta = proyectoModificado.Etiqueta;
        entity.FechaInicio = proyectoModificado.FechaInicio;
        entity.FechaFin = proyectoModificado.FechaFin;
      }

    }

  }
}
