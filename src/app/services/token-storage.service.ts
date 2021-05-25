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

  public getUser(): Usuario | null {
 
    const us = window.sessionStorage.getItem(USER_KEY);
    //console.log(us);
    //console.log(JSON.parse(us));
    
    this.data = JSON.parse(window.sessionStorage.getItem(USER_KEY));

    console.log(this.data);
    

    if(us){
      
      this.user = {nombre:this.data.nombre, rol:this.data.role}
      console.log(this.user);
      
      return this.user;
    }
    console.log("se vino por el null");
    
    return null;

  }

  public getUserTest(): string {
    return this.testUser;
  }

  public setUserTest(): void {
    this.testUser = "Alx Cervnates";
  }
}