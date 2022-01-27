using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Data.Modelo
{
    public partial class TiempoReal
    {
        public int IdTiempoReal { get; set; }
        public int IdPlanActividad { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int DuracionMinutos { get; set; }

        public virtual PlanActividad IdPlanActividadNavigation { get; set; }
    }
}
