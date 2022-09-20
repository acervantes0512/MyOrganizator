using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
    public partial class Proyecto
    {
        public int ProyectoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string Etiqueta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int DuracionMinutos { get; set; }
        public int Prioridad { get; set; }
        public int TipoProyectoId { get; set; }
        public int AsignacionProyectoId { get; set; }
        public int UsuarioId { get; set; }
        public virtual ICollection<PlanActividad> PlanesActividad{ get; set; }
        public virtual AsignacionProyectoPorDia AsignacionProyectoPorDia { get; set; }
        public virtual TipoProyecto TipoProyecto { get; set; }
        public virtual Usuario Usuario { get; set; }    
  }
}
