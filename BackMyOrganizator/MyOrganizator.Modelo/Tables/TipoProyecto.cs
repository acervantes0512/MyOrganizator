using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
  public partial class TipoProyecto
  {

    public int TipoProyectoId { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public bool Estado { get; set; }
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }
    public virtual ICollection<AsignacionTipoProyecto> AsignacionesTipoProyecto { get; set; }
    public virtual ICollection<TipoActividad> TiposActividad { get; set; }
    public virtual ICollection<Proyecto> Proyectos { get; set; }
  }
}
