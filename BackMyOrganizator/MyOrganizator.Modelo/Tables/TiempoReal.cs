using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
    public partial class TiempoReal
    {
        public int TiempoRealId { get; set; }
        public int PlanActividadId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int DuracionMinutos { get; set; }
        public virtual PlanActividad PlanActividad { get; set; }
  }
}
