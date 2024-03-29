using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyOrganizator.Control;
using MyOrganizator.Entities.Models.Request;
using MyOrganizator.Entities.Models.Response;
using MyOrganizator.Modelo.Tables;

namespace WebMyOrganizator.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TransversalController : ControllerBase
  {
    private readonly TimeOrganizatorContext _context;

    public TransversalController(TimeOrganizatorContext context)
    {
      _context = context;
    }

    [HttpGet("obtenerTiposProyecto")]
    public IActionResult Get(string username)
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;
      try
      {

        TransversalControl cProject = new TransversalControl();
        oRespuesta.Data = cProject.ObtenerTiposProyectos(username);

      }
      catch (Exception ex)
      {
        oRespuesta.Exito = 1;
        oRespuesta.Mensaje = ex.Message;
      }

      return Ok(oRespuesta);
    }

    [HttpGet("obtenerTiposTiempo")]
    public IActionResult GetTiposTiempo()
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;
      try
      {

        TransversalControl cProject = new TransversalControl();
        oRespuesta.Data = cProject.ObtenerTiposTiempo();

      }
      catch (Exception ex)
      {
        oRespuesta.Exito = 1;
        oRespuesta.Mensaje = ex.Message;
      }

      return Ok(oRespuesta);
    }

    [HttpGet("obtenerTiposActividad")]
    public IActionResult GetTiposActividad()
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;
      try
      {

        TransversalControl cProject = new TransversalControl();
        oRespuesta.Data = cProject.ObtenerTiposActividad();

      }
      catch (Exception ex)
      {
        oRespuesta.Exito = 1;
        oRespuesta.Mensaje = ex.Message;
      }

      return Ok(oRespuesta);
    }

    [HttpPost("crearTipoProyecto")]
    public IActionResult CrearTiposProyecto(RequestCrearTipoProyecto tipoProyecto)
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;
      try
      {

        TransversalControl cProject = new TransversalControl();
        cProject.CrearTipoProyecto(tipoProyecto);

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
