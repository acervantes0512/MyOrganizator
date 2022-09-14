import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Response } from '../Models/response';
import { IActividad } from '../shared/models/IActividad';
import { IActividadEditar } from '../shared/models/IActividadEditar';

@Injectable({
  providedIn: 'root'
})
export class ActividadesService {

  url : string = 'https://localhost:44372/api/Project/';
  urlActividad : string = 'https://localhost:44372/api/Actividad/';

  constructor(
    private _http: HttpClient
  ) { }

    obtenerActividadesPorProyecto(proyectoId:string): Observable<Response> {
      return this._http.get<Response>(this.url+'actividadesPorProyecto/'+proyectoId);
    }

    crearActividad(dataActividad:IActividad):Observable<Response> {
      return this._http.post<Response>(this.urlActividad+"crearActividad",dataActividad);
    }

    editarActividad(dataActividadEditar:IActividadEditar): Observable<Response> {
      return this._http.put<Response>(this.urlActividad+"editarActividad",dataActividadEditar);
    }
   
}
