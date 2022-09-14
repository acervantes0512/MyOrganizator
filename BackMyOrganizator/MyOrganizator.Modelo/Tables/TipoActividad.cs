using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
    public partial class TipoActividad
    {
        public int TipoActividadId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int TipoProyectoId { get; set; }
        public bool Estado { get; set; }
        public virtual TipoProyecto TipoProyecto { get; set; }
        public virtual ICollection<PlanActividad> PlanesActividad { get; set; }
  }
}
