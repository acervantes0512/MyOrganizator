using MyOrganizator.Modelo.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOrganizator.Data
{
  
  public class DatosUsuario
  {
    private readonly TimeOrganizatorContext contextoBD = new TimeOrganizatorContext();

    public Usuario ObtenerUsuarioPorUsername(string nombreUsuario)
    {

      Usuario us = contextoBD.Usuarios
        .Where(p => p.NombreUsuario == nombreUsuario).FirstOrDefault();

      return us;
    }

  }
}
