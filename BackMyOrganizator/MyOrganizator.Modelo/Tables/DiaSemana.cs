using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Modelo.Tables
{
  public class DiaSemana
  {
    public int DiaSemanaId { get; set; }
    public string Nombre { get; set; }
    public string TotalHoras { get; set; }    
    public string Estado { get; set; }
    public virtual ICollection<AsignacionTipoProyectoPorDia> AsignacionesTipoProyectoPorDia { get; set; }
  }
}
