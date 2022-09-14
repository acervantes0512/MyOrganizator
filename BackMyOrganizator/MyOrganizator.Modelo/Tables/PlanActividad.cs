using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
    public partial class PlanActividad
    {
        public int PlanActividadId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int DuracionMinutos { get; set; }
        public int TipoActividadId { get; set; }
        public int TipoTiempoId { get; set; }
        public int ProyectoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int OrdenEjecucion { get; set; }
        public virtual ICollection<TiempoReal> TiemposReales { get; set; }
        public virtual TipoActividad TipoActividad{ get; set; }
        public virtual TipoTiempo TipoTiempo { get; set; }
        public virtual Proyecto Proyecto { get; set; }


  }
}
