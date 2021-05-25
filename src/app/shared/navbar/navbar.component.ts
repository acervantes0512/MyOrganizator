import { Component, OnInit } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { TokenStorageService } from 'src/app/services/token-storage.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  isLogin = false;
  currentUser : any;
  userName: string;

  constructor( private router: Router,
               private routerModule: RouterModule,
               public token: TokenStorageService       
    ) { }

  ngOnInit(): void {
     this.currentUser = this.token.getToken();

    if(this.currentUser !== null)
      this.isLogin = true; 
  }

  Logout():void {
    this.token.signOut();
    window.location.reload();
    
  }

  updateFields():void {
    this.userName = "Test Alex"
  }

}
