import { Component, OnInit } from '@angular/core';
import { ProyectosService } from '../services/proyectos.service';
import {Response } from '../Models/response';
import { TipoProyectoService } from '../services/tipo-proyecto.service';
import { TokenStorageService } from '../services/token-storage.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-proyectos',
  templateUrl: './proyectos.component.html',
  styleUrls: ['./proyectos.component.css']
})
export class ProyectosComponent implements OnInit {

  public lst: any[];
  constructor(
              private proyectosService: ProyectosService,
              private tipoProyectoService: TipoProyectoService,
              private tokenStorage: TokenStorageService,
              private router: Router
            )
   {

    if(!this.tokenStorage.getUser()){
      this.router.navigate(['/login']);
    }else{
      this.getProyectos();
    }


   }

  ngOnInit(): void {

  }

  getProyectos(){
    var usuario = window.sessionStorage.getItem('username');
    this.proyectosService.getProyectos(usuario).subscribe( response => {
      this.lst = response.data;
      //this.getNombreTipoProyecto();
    })
  }

  getNombreTipoProyecto(idProyecto:number){

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
