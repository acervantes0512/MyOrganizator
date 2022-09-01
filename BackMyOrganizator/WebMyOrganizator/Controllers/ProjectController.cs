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
  public class ProjectController : ControllerBase
  {
    private readonly MyOrganizatorContext _context;

    public ProjectController(MyOrganizatorContext context)
    {
      _context = context;
    }

    [HttpGet("obtenerTodosLosProyectos/{nombreUsuario}")]
    public IActionResult Get(string nombreUsuario)
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;
      try
      {

        ProjectControl cProject = new ProjectControl();
        oRespuesta.Data = cProject.getAllProjects(nombreUsuario);

      }
      catch (Exception ex)
      {
        oRespuesta.Exito = 1;
        oRespuesta.Mensaje = ex.Message;
      }

      return Ok(oRespuesta);
    }


    [HttpGet("obtenerProyectoPorId/{id}")]
    public IActionResult GetProyecto(long id)
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;
      try
      {

        ProjectControl cProject = new ProjectControl();
        oRespuesta.Data = cProject.obtenerProyectoPorId(Convert.ToString(id));

      }
      catch (Exception ex)
      {
        oRespuesta.Exito = 1;
        oRespuesta.Mensaje = ex.Message;
      }

      return Ok(oRespuesta);
    }

    [HttpGet("actividadesPorProyecto/{idProyecto}")]
    public IActionResult Get(int idProyecto)
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;
      try
      {

        ProjectControl cProject = new ProjectControl();
        oRespuesta.Data = cProject.obtenerActividadesPorProyecto(idProyecto);

      }
      catch (Exception ex)
      {
        oRespuesta.Exito = 1;
        oRespuesta.Mensaje = ex.Message;
      }

      return Ok(oRespuesta);
    }

    [HttpPost("crearProyecto")]
    public IActionResult Add(RequestCrearProyecto peticion)
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;

      try
      {
        ProjectControl cProject = new ProjectControl();
        cProject.crearProyecto(peticion);
        oRespuesta.Exito = 1;
      }
      catch (Exception ex)
      {
        oRespuesta.Mensaje = ex.Message;
      }
      return Ok(oRespuesta);
    }



    [HttpPut("actualizarProyecto")]
    public IActionResult Edit(RequestCrearProyecto peticionModificar)
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;
      try
      {
        ProjectControl cProject = new ProjectControl();
        cProject.actualizarProyecto(peticionModificar);
        oRespuesta.Exito = 1;
      }
      catch (Exception ex)
      {
        oRespuesta.Mensaje = ex.Message;
      }
      return Ok(oRespuesta);
    }
    

    [HttpDelete("{Id}")]
    public IActionResult Delete(int Id)
    {
      Respuesta oRespuesta = new Respuesta();
      oRespuesta.Exito = 0;

      try
      {

        ProjectControl cProject = new ProjectControl();
        cProject.eliminarProyecto(Id);
        oRespuesta.Exito = 1;

      }
      catch (Exception ex)
      {
        oRespuesta.Mensaje = ex.Message;
      }

      return Ok(oRespuesta);

    }

  }
}
