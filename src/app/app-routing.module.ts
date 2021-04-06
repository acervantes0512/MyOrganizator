import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ActividadesComponent } from './actividades/actividades.component';
import { HomeComponent } from './home/home.component';
import { ProyectoComponent } from './proyecto/proyecto.component';
import { ProyectosComponent } from './proyectos/proyectos.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent},
  { path: 'actividades', component: ActividadesComponent},
  { path: 'proyectos', component: ProyectosComponent},
  { path: 'proyecto/:id', component: ProyectoComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
