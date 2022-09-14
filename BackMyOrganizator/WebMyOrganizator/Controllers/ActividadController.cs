using System;
using Microsoft.AspNetCore.Mvc;
using MyOrganizator.Control;
using MyOrganizator.Entities.Models.Request;
using MyOrganizator.Entities.Models.Response;
using MyOrganizator.Modelo.Tables;

namespace WebMyOrganizator.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ActividadController : ControllerBase
  {
    private readonly TimeOrganizatorContext _context;

    public ActividadController(TimeOrganizatorContext context)
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

    [HttpPut("editarActividad")]
    public IActionResult EditarActividad(RequestEditarActividad peticion)
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;
      try
      {

        ActividadControl cProject = new ActividadControl();
        cProject.EditarActividad(peticion);
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
