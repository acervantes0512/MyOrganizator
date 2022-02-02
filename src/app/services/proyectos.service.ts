import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Response } from '../Models/response';
import { IProyecto } from '../shared/models/IProyecto';

@Injectable({
  providedIn: 'root'
})
export class ProyectosService {

  url : string = 'https://localhost:44372/api/Project/';

  constructor(
    private _http: HttpClient
  ) { }

    getProyectos(username:string): Observable<Response> {
        return this._http.get<Response>(this.url+'obtenerTodosLosProyectos/'+username);
    }

    getProyecto(id:number): Observable<Response> {
      return this._http.get<Response>(this.url+"obtenerProyectoPorId/"+id);
    }

    crearProyecto(proyecto:IProyecto): Observable<Response>{
      return this._http.post<Response>(this.url+"crearProyecto", proyecto)
    }

}
