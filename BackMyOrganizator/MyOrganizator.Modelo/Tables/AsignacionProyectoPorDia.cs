using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
    public partial class AsignacionProyectoPorDia
    {
        public int AsignacionProyectoPorDiaId { get; set; }
        public int AsignacionTipoProyectoPorDiaId { get; set; }
        public int Porcentaje { get; set; }
        public bool Estado { get; set; }
        public virtual AsignacionTipoProyectoPorDia AsignacionTipoProyectoPorDia { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }

  }
}
