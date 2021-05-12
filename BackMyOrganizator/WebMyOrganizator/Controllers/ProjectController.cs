<<<<<<< HEAD
using System;
=======
﻿using System;
>>>>>>> 60cc4f777525445d4b218ce1200a99c11e3b418a
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using MyOrganizator.Control;
=======
>>>>>>> 60cc4f777525445d4b218ce1200a99c11e3b418a
using MyOrganizator.Entities.Models;
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

        [HttpGet]
        public IActionResult Get()
        {
            Respuesta oRespuesta = new Respuesta();
            oRespuesta.Exito = 0;
            try {

<<<<<<< HEAD
              //oRespuesta.Data = this._context.Projects.ToList();
              ProjectControl cProject = new ProjectControl(); 
              oRespuesta.Data = cProject.getAllProjects();

               }
            catch (Exception ex)
            {
              oRespuesta.Exito = 1;
              oRespuesta.Mensaje = ex.Message;
=======
                oRespuesta.Exito = 1;
                oRespuesta.Data = this._context.Projects.ToList();

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
>>>>>>> 60cc4f777525445d4b218ce1200a99c11e3b418a
            }

            return Ok(oRespuesta);
        }


        [HttpGet("{id}")]
        public IActionResult GetProyecto(long id)
        {
            Respuesta oRespuesta = new Respuesta();
            oRespuesta.Exito = 0;
            try
            {
<<<<<<< HEAD
                //oRespuesta.Data = this._context.Projects.Find(id);

                ProjectControl cProject = new ProjectControl();
                oRespuesta.Data = cProject.getAllProjects().FirstOrDefault(x => x.ProjectId == id);

      }
            catch (Exception ex)
            {
              oRespuesta.Exito = 1;
              oRespuesta.Mensaje = ex.Message;
=======

                oRespuesta.Exito = 1;
                oRespuesta.Data = this._context.Projects.Find(id);

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
>>>>>>> 60cc4f777525445d4b218ce1200a99c11e3b418a
            }

            return Ok(oRespuesta);
        }

        [HttpPost]
        public IActionResult Add(ProjectRequest oModel)
        {
            Respuesta oRespuesta = new Respuesta();
            oRespuesta.Exito = 0;

            try
            {

                Project oProject = new Project();
                oProject.ProjectId = oModel.ProjectId;
                oProject.Name = oModel.Name;
                oProject.Description = oModel.Description;
                oProject.State = oModel.State;
                oProject.Label = oModel.Label;
                oProject.RegisterDate = oModel.RegisterDate;
                oProject.StartDate = oModel.StartDate;
                oProject.EndDate = oModel.EndDate;
                oProject.ProjectTypeId = oModel.ProjectTypeId;
                oProject.DistDayProjectId = oModel.DistDayProjectId;

                this._context.Projects.Add(oProject);
                this._context.SaveChanges();

                oRespuesta.Exito = 1;

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);

        }



        [HttpPut]
        public IActionResult Edit(ProjectRequest oModel)
        {
            Respuesta oRespuesta = new Respuesta();
            oRespuesta.Exito = 0;

            try
            {

                Project oProject = this._context.Projects.Find(oModel.ProjectId);
                oProject.ProjectId = oModel.ProjectId;
                oProject.Name = oModel.Name;
                oProject.Description = oModel.Description;
                oProject.State = oModel.State;
                oProject.Label = oModel.Label;
                oProject.RegisterDate = oModel.RegisterDate;
                oProject.StartDate = oModel.StartDate;
                oProject.EndDate = oModel.EndDate;
                oProject.ProjectTypeId = oModel.ProjectTypeId;
                oProject.DistDayProjectId = oModel.DistDayProjectId;

                this._context.Entry(oProject).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this._context.SaveChanges();

                oRespuesta.Exito = 1;

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);

        }


        [HttpDelete("{Id}")]
        public IActionResult Delete(long Id)
        {
            Respuesta oRespuesta = new Respuesta();
            oRespuesta.Exito = 0;

            try
            {

                Project oProject = this._context.Projects.Find(Id);

                this._context.Remove(oProject);
                this._context.SaveChanges();

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
