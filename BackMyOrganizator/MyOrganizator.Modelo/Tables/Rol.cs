using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
    public partial class Rol
    {

        public int RolId { get; set; }
        public string NombreRol { get; set; }
        public int Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }

  }
}
