using MyOrganizator.Modelo.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOrganizator.Data
{
  
  public class DatosTransversal

  {
    private readonly TimeOrganizatorContext contextoBD = new TimeOrganizatorContext();

    public List<TipoProyecto> ObtenerTiposProyectos(int idUsuario)
    {
      return contextoBD.TipoProyectos.Where(x => x.Usuario.UsuarioId == idUsuario).ToList();      
    }

    public List<TipoTiempo> ObtenerTiposTiempo()
    {
      return contextoBD.TipoTiempos.ToList();
    }

    public List<TipoActividad> ObtenerTiposActividad()
    {
      return contextoBD.TipoActividads.ToList();
    }

    public void CrearTipoProyecto(TipoProyecto obj)
    {
      contextoBD.TipoProyectos.Add(obj);
      contextoBD.SaveChanges();
    }

  }
}
