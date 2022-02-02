using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Entities.Models.Request
{
  public class RequestCrearProyecto
  {
    public string nombreProyecto { get; set; }
    public string descripcionProyecto{ get; set; }
    public string etiquetas { get; set; }
    public string porcentajeAsignacion { get; set; }
    public string tipoProyecto { get; set; }
    public string fechaInicio { get; set; }
    public string fechaFin { get; set; }
    public string usuario { get; set; }
  }
}
