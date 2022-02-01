using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Data.Modelo
{
    public partial class AsignacionProyecto
    {
        public AsignacionProyecto()
        {
            PlanActividadIdProyectoNavigations = new HashSet<PlanActividad>();
            PlanActividadIdTipoActividadNavigations = new HashSet<PlanActividad>();
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdAsignacionProyecto { get; set; }
        public int IdAsignacionTipoProy { get; set; }
        public int Porcentaje { get; set; }
        public bool Estado { get; set; }

        public virtual AsignacionTipoProyecto IdAsignacionProyectoNavigation { get; set; }
        public virtual ICollection<PlanActividad> PlanActividadIdProyectoNavigations { get; set; }
        public virtual ICollection<PlanActividad> PlanActividadIdTipoActividadNavigations { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
