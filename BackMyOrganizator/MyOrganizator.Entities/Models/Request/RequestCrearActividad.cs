using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Entities.Models.Request
{
  public class RequestCrearActividad
  {
    public string NombreActividad { get; set; }
    public string Descripcion { get; set; }
    public string DuracionMinutos { get; set; }
    public string FechaInicio { get; set; }
    public string FechaFin { get; set; }
    public string OrdenEjecucion { get; set; }
    public string IdTipoTiempo { get; set; }
    public string IdTipoActividad { get; set; }
    public string IdProyecto { get; set; }
  }
}
