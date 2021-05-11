using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOrganizator.Entities.Models;
using MyOrganizator.Entities.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMyOrganizator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectTypeController : ControllerBase
    {
        private readonly MyOrganizatorContext _context;
        public ProjectTypeController(MyOrganizatorContext context)
        {
            _context = context;
        }

        [HttpGet("{Id}")]
        public IActionResult getName(long Id)
        {
            Respuesta oRespuesta = new Respuesta();
            oRespuesta.Exito = 0;
            try
            {

                oRespuesta.Exito = 1;
                oRespuesta.Data = this._context.ProjectTypes.Find(Id);

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }

    }
}
