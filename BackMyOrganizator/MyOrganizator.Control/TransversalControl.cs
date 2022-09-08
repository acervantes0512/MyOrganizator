using MyOrganizator.Data;
using MyOrganizator.Modelo.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Control
{
  public class TransversalControl
  {

    DatosTransversal datosTransversal = new DatosTransversal();
    DatosUsuario datosUsuario = new DatosUsuario();

    public List<TipoProyecto> ObtenerTiposProyectos(string username)
    {
      return datosTransversal.ObtenerTiposProyectos(datosUsuario.ObtenerUsuarioPorUsername(username).UsuarioId);
    }

    public List<TipoActividad> ObtenerTiposActividad()
    {
      return datosTransversal.ObtenerTiposActividad();
    }

    public List<TipoTiempo> ObtenerTiposTiempo()
    {
      return datosTransversal.ObtenerTiposTiempo();
    }

  }
}
