using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOrganizator.Entities;
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
  public class HomeController : ControllerBase
  {

    [HttpGet]
    [Route("all")]
    public IActionResult Get()
    {

      Respuesta oRta = new Respuesta();

      try
      {
        Home h = new Home();
        h.nombre = "Este es el Home";
        h.descripcion = "Descripción 1 del Home para la prueba del servicio";
        h.descripcion2 = "Descripción 2 del home para prueba del servicio 2";

        oRta.Exito = 1;
        oRta.Mensaje = "Consulta Exitosa";
        oRta.Data = h;

      }
      catch (Exception e)
      {
        oRta.Exito = 0;
        oRta.Mensaje = e.Message;
      }

      return Ok(oRta);
    }

    [HttpGet]
    [Route("admin")]
    [Authorize (Roles = "admin")]
    public IActionResult GetAdmin()
    {

      Respuesta oRta = new Respuesta();

      try
      {
        Home h = new Home();
        h.nombre = "Este es el Home del ADMIN";
        h.descripcion = " ADMIN Descripción 1 del Home para la prueba del servicio";
        h.descripcion2 = " ADMIN Descripción 2 del home para prueba del servicio 2";

        oRta.Exito = 1;
        oRta.Mensaje = "Consulta Exitosa";
        oRta.Data = h;

      }
      catch (Exception e)
      {
        oRta.Exito = 0;
        oRta.Mensaje = e.Message;
      }

      return Ok(oRta);
    }


    [HttpGet]
    [Route("user")]
    public IActionResult GetUsuario ()
    {

      Respuesta oRta = new Respuesta();

      try
      {
        Home h = new Home();
        h.nombre = "Este es el Home del USER";
        h.descripcion = " USER Descripción 1 del Home para la prueba del servicio";
        h.descripcion2 = " USER Descripción 2 del home para prueba del servicio 2";

        oRta.Exito = 1;
        oRta.Mensaje = "Consulta Exitosa";
        oRta.Data = h;

      }
      catch (Exception e)
      {
        oRta.Exito = 0;
        oRta.Mensaje = e.Message;
      }

      return Ok(oRta);
    }

    [HttpGet]
    [Route("mod")]
    public IActionResult GetMod()
    {

      Respuesta oRta = new Respuesta();

      try
      {
        Home h = new Home();
        h.nombre = "Este es el Home del MODERADOR";
        h.descripcion = " MODERADOR Descripción 1 del Home para la prueba del servicio";
        h.descripcion2 = " MODERADOR Descripción 2 del home para prueba del servicio 2";

        oRta.Exito = 1;
        oRta.Mensaje = "Consulta Exitosa";
        oRta.Data = h;

      }
      catch (Exception e)
      {
        oRta.Exito = 0;
        oRta.Mensaje = e.Message;
      }

      return Ok(oRta);
    }

  }
}
