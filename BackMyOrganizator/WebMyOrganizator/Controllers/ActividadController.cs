using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyOrganizator.Control;
using MyOrganizator.Data.Modelo;
using MyOrganizator.Entities.Models.Request;
using MyOrganizator.Entities.Models.Response;

namespace WebMyOrganizator.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ActividadController : ControllerBase
  {
    private readonly MyOrganizatorContext _context;

    public ActividadController(MyOrganizatorContext context)
    {
      _context = context;
    }

    [HttpPost("crearActividad")]
    public IActionResult CrearActividad(RequestCrearActividad peticion)
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;
      try
      {

        ActividadControl cProject = new ActividadControl();
        cProject.CrearActividad(peticion);
        oRespuesta.Exito = 1;

      }
      catch (Exception ex)
      {
        oRespuesta.Exito = 1;
        oRespuesta.Mensaje = ex.Message;
      }

      return Ok(oRespuesta);
    }



  }
}
