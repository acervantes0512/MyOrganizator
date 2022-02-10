using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyOrganizator.Control;
using MyOrganizator.Data.Modelo;
using MyOrganizator.Entities.Models.Response;

namespace WebMyOrganizator.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TransversalController : ControllerBase
  {
    private readonly MyOrganizatorContext _context;

    public TransversalController(MyOrganizatorContext context)
    {
      _context = context;
    }

    [HttpGet("obtenerTiposProyecto")]
    public IActionResult Get()
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;
      try
      {

        TransversalControl cProject = new TransversalControl();
        oRespuesta.Data = cProject.ObtenerTiposProyectos();

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



  }
}
