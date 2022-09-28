import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Response } from '../Models/response';
import { ICrearTipoProyecto } from '../shared/models/ICrearTipoProyecto';

@Injectable({
  providedIn: 'root'
})
export class TransversalService {

  _url : string = 'https://localhost:44372/api/Transversal/';
  constructor(
    private _http: HttpClient
  ) { }

  obtenerTiposProyectos(username:string):Observable<Response> {
    return this._http.get<Response>(this._url+'obtenerTiposProyecto/?username='+username);
  }

  obtenerTiposTiempo():Observable<Response> {
    return this._http.get<Response>(this._url+'obtenerTiposTiempo/');
  }

  obtenerTiposActividad():Observable<Response> {
    return this._http.get<Response>(this._url+'obtenerTiposActividad/');
  }

  crearTipoProyecto(requestTipoProyecto:ICrearTipoProyecto):Observable<Response> {
    return this._http.post<Response>(this._url+'crearTipoProyecto',requestTipoProyecto);
  }

}
