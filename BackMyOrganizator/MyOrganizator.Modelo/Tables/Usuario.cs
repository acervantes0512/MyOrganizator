using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
    public partial class Usuario
    {

        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }
        public int RolId { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Alias { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual ICollection<TipoProyecto> TiposProyecto { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
  }
}
