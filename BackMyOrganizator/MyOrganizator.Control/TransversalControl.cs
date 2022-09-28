using MyOrganizator.Data;
using MyOrganizator.Entities.Models.Request;
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

    public void CrearTipoProyecto(RequestCrearTipoProyecto obj)
    {
      datosTransversal.CrearTipoProyecto(mapearRequestEnModelo(obj));
    }

    private TipoProyecto mapearRequestEnModelo(RequestCrearTipoProyecto requestTipoProyecto)
    {
      try
      {     
        TipoProyecto tipoProyecto = new TipoProyecto()
        {
          Nombre = requestTipoProyecto.nombre,
          Descripcion = requestTipoProyecto.descripcion,
          Estado = true,
          UsuarioId = Convert.ToInt32(datosUsuario.ObtenerUsuarioPorUsername(requestTipoProyecto.username).UsuarioId)        
        };
        return tipoProyecto;
      }
      catch (Exception ex)
      {

        throw ex;
      }
      return null;
     
    }

    }
}
