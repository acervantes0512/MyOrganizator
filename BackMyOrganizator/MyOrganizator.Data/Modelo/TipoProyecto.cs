using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Data.Modelo
{
    public partial class TipoProyecto
    {
        public TipoProyecto()
        {
            AsignacionTipoProyectos = new HashSet<AsignacionTipoProyecto>();
            PlanActividads = new HashSet<PlanActividad>();
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdTipoProyecto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public virtual TipoActividad TipoActividad { get; set; }
        public virtual ICollection<AsignacionTipoProyecto> AsignacionTipoProyectos { get; set; }
        public virtual ICollection<PlanActividad> PlanActividads { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
