using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Data.Modelo
{
    public partial class Rol
    {
        public Rol()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public int Estado { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
