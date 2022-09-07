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

    public List<TipoProyecto> ObtenerTiposProyectos(int idUsuario)
    {
      return contextoBD.TipoProyectos.Where(x => x.IdUsuario == idUsuario).ToList();      
    }

    public List<TipoTiempo> ObtenerTiposTiempo()
    {
      return contextoBD.TipoTiempos.ToList();
    }

    public List<TipoActividad> ObtenerTiposActividad()
    {
      return contextoBD.TipoActividads.ToList();
    }

  }
}
