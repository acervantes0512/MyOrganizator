using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Entities.Models.Request
{
  public class RequestEditarProyecto
  {
    public Int32 idProyecto { get; set; }
    public string nombreProyecto { get; set; }
    public string descripcionProyecto{ get; set; }
    public string etiquetas { get; set; }
    public string porcentajeAsignacion { get; set; }
    public Int32 tipoProyecto { get; set; }
    public string fechaInicio { get; set; }
    public string fechaFin { get; set; }
    public string usuario { get; set; }
  }
}
