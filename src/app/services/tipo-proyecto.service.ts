import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Response } from '../Models/response';

@Injectable({
  providedIn: 'root'
})
export class TipoProyectoService {

  url : string = 'https://localhost:44372/api/ProjectType';

  constructor(
    private _http: HttpClient
  ) { }

  getTipoProyecto(id:number): Observable<Response> {
    return this._http.get<Response>(this.url+"/"+id);
  }

}
