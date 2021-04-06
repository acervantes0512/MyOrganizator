import { Component, OnInit } from '@angular/core';
import { ProyectosService } from '../services/proyectos.service';
import {Response } from '../Models/response';
import { TipoProyectoService } from '../services/tipo-proyecto.service';

@Component({
  selector: 'app-proyectos',
  templateUrl: './proyectos.component.html',
  styleUrls: ['./proyectos.component.css']
})
export class ProyectosComponent implements OnInit {

  public lst: any[];
  constructor(
              private proyectosService: ProyectosService,
              private tipoProyectoService: TipoProyectoService
            )
   {
   }

  ngOnInit(): void {

    this.getProyectos();


  }

  getProyectos(){
    this.proyectosService.getProyectos().subscribe( response => {
      this.lst = response.data;
      //this.getNombreTipoProyecto();
    })
  }

  getNombreTipoProyecto(idProyecto:number){

    debugger;



    console.log(this.lst);

    for(var el of this.lst){

      this.tipoProyectoService.getTipoProyecto(idProyecto).subscribe( resp => {
        console.log(resp);


        return resp.data.name;
        //el.push(tipo) = "tipoo";
        //console.log(this.lst);
      });

    }

  }

}
