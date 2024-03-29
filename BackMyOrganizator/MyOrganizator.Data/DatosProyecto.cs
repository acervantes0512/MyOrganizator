using MyOrganizator.Modelo.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOrganizator.Data
{

  public class DatosProyecto
  {
    private readonly TimeOrganizatorContext contextoBD = new TimeOrganizatorContext();
    public List<Proyecto> ProyectosPorIdUsuario(int idUser)
    {
      List<Proyecto> rta = new List<Proyecto>();
      using (var context = new TimeOrganizatorContext())
      {
        var proyecto = context.Proyectos
          .Where(p => p.UsuarioId == idUser && p.Estado).ToList();
        rta = proyecto;
      }

      return rta;
    }

    public Proyecto obtenerProyectoPorId(string idProyecto)
    {
      return contextoBD.Proyectos.Where(p => p.ProyectoId == Convert.ToInt32(idProyecto)).FirstOrDefault();          
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
      var entity = contextoBD.Proyectos.Find(proyectoModificado.ProyectoId);

      if(entity != null)
      {
        entity.TipoProyectoId = proyectoModificado.TipoProyectoId;
        entity.Nombre = proyectoModificado.Nombre;
        entity.Descripcion = proyectoModificado.Descripcion;
        entity.Etiqueta = proyectoModificado.Etiqueta;
        entity.FechaInicio = proyectoModificado.FechaInicio;
        entity.FechaFin = proyectoModificado.FechaFin;

        contextoBD.Proyectos.Update(entity);
        contextoBD.SaveChanges();
      }

    }

  }
}
