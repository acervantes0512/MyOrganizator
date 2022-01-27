using MyOrganizator.Data.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOrganizator.Data
{
  public class gestionDatos
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

    public int ObtenerIdUsuario(string nombreUsuario)
    {

        Usuario us = contextoBD.Usuarios
          .Where(p => p.NombreUsuario == nombreUsuario).FirstOrDefault();

      return us.IdUsuario;
      
    }

  }
}
