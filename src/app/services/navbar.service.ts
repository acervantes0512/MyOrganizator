import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class NavbarService {

  private navStateSource = new Subject<string>();
  navState$ = this.navStateSource.asObservable();

  constructor() { 
   /*  this.navState$.subscribe( (state) => this.state = state) */
  }

  setNavbarState( state: string ){
    this.navStateSource.next(state);
  }
}
