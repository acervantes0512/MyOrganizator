using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Data.Modelo
{
    public partial class TipoTiempo
    {
        public int IdTipoTiempo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
