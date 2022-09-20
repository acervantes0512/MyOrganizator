using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
    public partial class AsignacionTipoProyectoPorDia
    {
        public int AsignacionTipoProyectoPorDiaId { get; set; }
        public int TipoProyectoId { get; set; }
        public int? DiaSemanaId { get; set; }
        public int Porcentaje { get; set; }
        public bool Estado { get; set; }
        public virtual TipoProyecto TipoProyecto { get; set; }
        public virtual DiaSemana DiaSemana { get; set; }
        public virtual ICollection<AsignacionProyectoPorDia> AsignacionesProyectoPorDia { get; set; }

  }
}
