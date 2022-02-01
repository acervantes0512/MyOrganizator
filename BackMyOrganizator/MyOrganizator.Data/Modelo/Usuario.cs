using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Data.Modelo
{
    public partial class Usuario
    {
        public Usuario()
        {
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }
        public int IdRol { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Alias { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
