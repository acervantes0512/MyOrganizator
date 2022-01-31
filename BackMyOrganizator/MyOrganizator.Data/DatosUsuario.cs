using MyOrganizator.Data.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOrganizator.Data
{
  
  public class DatosUsuario
  {
    private readonly MyOrganizatorContext contextoBD = new MyOrganizatorContext();

    public Usuario ObtenerUsuarioPorUsername(string nombreUsuario)
    {

      Usuario us = contextoBD.Usuarios
        .Where(p => p.NombreUsuario == nombreUsuario).FirstOrDefault();

      return us;
    }

  }
}
