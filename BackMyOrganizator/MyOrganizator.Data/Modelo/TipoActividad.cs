using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Data.Modelo
{
    public partial class TipoActividad
    {
        public int IdTipoActividad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoProyecto { get; set; }
        public bool Estado { get; set; }

        public virtual TipoProyecto IdTipoActividadNavigation { get; set; }
    }
}
