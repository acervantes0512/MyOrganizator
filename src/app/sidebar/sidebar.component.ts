import { Component, OnInit } from '@angular/core';

declare const $: any;
declare interface RouteInfo {
  path: string;
  title: string;
  icon: string;
  class: string;
}

export const ROUTES: RouteInfo[] = [
  { path: '/home', title: 'Inicio  ',  icon: 'fa fa-home', class: '' },
  { path: '/actividades', title: 'Actividades',  icon:'fa fa-tasks', class: '' },
  { path: '/table', title: 'Proyectos',  icon:'fa fa-table', class: '' },
  { path: '/typography', title: 'Typography',  icon:'fa fa-paragraph', class: '' },
  { path: '/notifications', title: 'Notifications',  icon:'fa fa-envelope', class: '' },
  { path: '/upgrade', title: 'Upgrade to PRO',  icon:'fa fa-crown', class: 'active-pro' },
];


@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {
  menuItems: any[];
  constructor() { }

  ngOnInit(): void {
    this.menuItems = ROUTES.filter(menuItem => menuItem);
  }

}
