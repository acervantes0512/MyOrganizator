import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Response } from '../Models/response';

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

    crearProyecto(proyecto:any): Observable<Response>{
      return this._http.post<Response>(this.url+"crearProyecto", proyecto)
    }

}
