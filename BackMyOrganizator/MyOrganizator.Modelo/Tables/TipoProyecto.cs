using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Data.Modelo
{
  public partial class TipoProyecto
  {

    public int TipoProyectoId { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public bool Estado { get; set; }
    public virtual ICollection<TipoActividad> TiposActividades { get; set; }
  }
}
