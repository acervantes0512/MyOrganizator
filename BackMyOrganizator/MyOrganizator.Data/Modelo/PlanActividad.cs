using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Data.Modelo
{
    public partial class PlanActividad
    {
        public PlanActividad()
        {
            TiempoReals = new HashSet<TiempoReal>();
        }

        public int IdPlanActividad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int DuracionMinutos { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int OrdenEjecucion { get; set; }


        public virtual ICollection<TiempoReal> TiempoReals { get; set; }

  }
}
