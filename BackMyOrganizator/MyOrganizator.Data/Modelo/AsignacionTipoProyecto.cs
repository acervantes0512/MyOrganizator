using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Data.Modelo
{
    public partial class AsignacionTipoProyecto
    {
        public int IdAsignacionTipoProy { get; set; }
        public int IdTipoProyecto { get; set; }
        public int Porcentaje { get; set; }
        public bool Estado { get; set; }

        public virtual TipoProyecto IdTipoProyectoNavigation { get; set; }
        public virtual AsignacionProyecto AsignacionProyecto { get; set; }
    }
}
