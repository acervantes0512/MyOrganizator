using MyOrganizator.Data;
using MyOrganizator.Data.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Control
{
  public class TransversalControl
  {

    DatosTransversal datosTransversal = new DatosTransversal();

    public List<TipoProyecto> ObtenerTiposProyectos()
    {
      return datosTransversal.ObtenerTiposProyectos();
    } 

  }
}
