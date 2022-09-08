using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
    public partial class AsignacionProyecto
    {
        public int AsignacionProyectoId { get; set; }
        public int IdAsignacionTipoProy { get; set; }
        public int Porcentaje { get; set; }
        public bool Estado { get; set; }
        public virtual AsignacionTipoProyecto AsignacionTipoProyecto { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }

  }
}
