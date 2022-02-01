using MyOrganizator.Data.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOrganizator.Data
{
  
  public class DatosTransversal

  {
    private readonly MyOrganizatorContext contextoBD = new MyOrganizatorContext();

    public List<TipoProyecto> ObtenerTiposProyectos()
    {
      return contextoBD.TipoProyectos.ToList();
    }

  }
}
