import { R3TargetBinder } from '@angular/compiler';
import { Injectable } from '@angular/core';
import { Usuario } from '../Models/usuario';

const TOKEN_KEY = 'auth-token';
const USER_KEY = 'auth-user';

@Injectable({
  providedIn: 'root'
})
export class TokenStorageService {

  testUser = "No Loggin";
  user : Usuario | null ;
  data: any;
  rta: string;

  constructor() { }

  signOut(): void {
    window.sessionStorage.clear();
  }

  public saveToken(token: string): void {
    window.sessionStorage.removeItem(TOKEN_KEY);
    window.sessionStorage.setItem(TOKEN_KEY, token);
  }

  public getToken(): string | null {
    return window.sessionStorage.getItem(TOKEN_KEY);
  }

  public saveUser(user: any): void {
    window.sessionStorage.removeItem(USER_KEY);
    window.sessionStorage.setItem(USER_KEY, JSON.stringify(user));
  }

  public getUser(): string | null {
    const us = window.sessionStorage.getItem(USER_KEY);

    if(us){
     return JSON.parse(window.sessionStorage.getItem(USER_KEY)).nombre;
    }

    return null;
  }

  public getUserTest(): string {
    return this.testUser;
  }

  public setUserTest(): void {
    this.testUser = "Alx Cervnates";
  }
}