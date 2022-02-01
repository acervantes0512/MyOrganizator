import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Response } from '../Models/response';

@Injectable({
  providedIn: 'root'
})
export class TransversalService {

  _url : string = 'https://localhost:44372/api/Transversal/';
  constructor(
    private _http: HttpClient
  ) { }

  obtenerTiposProyectos():Observable<Response> {
    return this._http.get<Response>(this._url+'obtenerTiposProyecto/');
  }

}
