import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Response } from '../Models/response';

@Injectable({
  providedIn: 'root'
})
export class ProyectosService {

  url : string = 'https://localhost:44372/api/Project/acervantes';

  constructor(
    private _http: HttpClient
  ) { }

    getProyectos(): Observable<Response> {
        return this._http.get<Response>(this.url);
    }

    getProyecto(id:number): Observable<Response> {
      return this._http.get<Response>(this.url+"/"+id);
  }

}
