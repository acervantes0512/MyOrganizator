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
          .Where(p => p.IdUsuario == idUser).ToList();
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
 
  }
}
