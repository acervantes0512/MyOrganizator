using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
    public partial class AsignacionTipoProyecto
    {
        public int AsignacionTipoProyectoId { get; set; }
        public int TipoProyectoId { get; set; }
        public int Porcentaje { get; set; }
        public bool Estado { get; set; }
        public virtual TipoProyecto TipoProyecto { get; set; }
        public virtual ICollection<AsignacionProyecto> AsignacionesProyecto { get; set; }

  }
}
