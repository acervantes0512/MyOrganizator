import { Component, OnInit } from '@angular/core';

declare const $: any;
declare interface RouteInfo {
  path: string;
  title: string;
  icon: string;
  class: string;
}

export const ROUTES: RouteInfo[] = [
  { path: '/home', title: 'Inicio  ',  icon: 'fa fa-home mr-2 lead', class: 'd-block p-3 text-light' },
  { path: '/actividades', title: 'Actividades',  icon:'fa fa-tasks mr-2 lead', class: 'd-block p-3 text-light' },
  { path: '/proyectos', title: 'Proyectos',  icon:'fa fa-table mr-2 lead', class: 'd-block p-3 text-light' },
  { path: '/typography', title: 'Typography',  icon:'fa fa-paragraph mr-2 lead', class: 'd-block p-3 text-light' },
  { path: '/notifications', title: 'Notifications',  icon:'fa fa-envelope mr-2 lead', class: 'd-block p-3 text-light' },
  { path: '/upgrade', title: 'Upgrade to PRO',  icon:'fa fa-crown mr-2 lead', class: 'd-block active-pro p-3 text-light' },
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
