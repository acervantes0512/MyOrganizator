using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Data.Modelo
{
    public partial class Proyecto
    {
        public int IdProyecto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string Etiqueta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int DuracionMinutos { get; set; }
        public int IdTipoProyecto { get; set; }
        public int IdAsignacionProyecto { get; set; }
        public int IdUsuario { get; set; }

        public virtual AsignacionProyecto IdAsignacionProyectoNavigation { get; set; }
        public virtual TipoProyecto IdTipoProyectoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
