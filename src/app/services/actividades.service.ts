import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Response } from '../Models/response';

@Injectable({
  providedIn: 'root'
})
export class ActividadesService {

  url : string = 'https://localhost:44372/api/Project/';

  constructor(
    private _http: HttpClient
  ) { }

    obtenerActividadesPorProyecto(idProyecto:string): Observable<Response> {
      return this._http.get<Response>(this.url+'actividadesPorProyecto/'+idProyecto);
    }

}
