using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizator.Entities.Models.Response
{
    public class Respuesta
    {
        public int Exito { get; set; }
        public string Mensaje{ get; set; }

        public object Data { get; set; }
    }
}
