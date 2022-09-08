using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
    public partial class TipoTiempo
    {
        public int TipoTiempoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public virtual ICollection<PlanActividad> PlanesActividad { get; set; }
  }
}
