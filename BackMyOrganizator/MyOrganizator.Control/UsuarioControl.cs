using MyOrganizator.Data;
using MyOrganizator.Data.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Control
{
  public class UsuarioControl
  {

    DatosUsuario datosUsuario = new DatosUsuario();

    public Usuario ObtenerUsuarioPorUsername(string username)
    {
      return datosUsuario.ObtenerUsuarioPorUsername(username);
    } 

  }
}
