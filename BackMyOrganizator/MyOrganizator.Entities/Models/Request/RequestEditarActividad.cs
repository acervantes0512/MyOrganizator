using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Entities.Models.Request
{
  public class RequestEditarActividad
  {
    public int ActividadId { get; set; }
    public string NombreActividad { get; set; }
    public string Descripcion { get; set; }
    public int DuracionMinutos { get; set; }
    public string FechaInicio { get; set; }
    public string FechaFin { get; set; }
    public string OrdenEjecucion { get; set; }
    public int IdTipoTiempo { get; set; }
    public int IdTipoActividad { get; set; }
    public int IdProyecto { get; set; }
  }
}
