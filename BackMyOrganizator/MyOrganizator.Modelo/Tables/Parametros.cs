using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Modelo.Tables
{
  public class Parametros
  {
    public int ParametrosId { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Valor { get; set; }
    public DateTime FechaCreación { get; set; }
    public string Estado { get; set; }
  }
}
