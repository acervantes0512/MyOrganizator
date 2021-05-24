import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ActividadesComponent } from './actividades/actividades.component';
import { BoardAdminComponent } from './board-admin/board-admin.component';
import { BoardUserComponent } from './board-user/board-user.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { ProyectoComponent } from './proyecto/proyecto.component';
import { ProyectosComponent } from './proyectos/proyectos.component';
import { ProfileComponent } from './usuario/perfil/profile.component';
import { RegisterComponent } from './usuario/register/register.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent},
  { path: 'actividades', component: ActividadesComponent},
  { path: 'proyectos', component: ProyectosComponent},
  { path: 'proyecto/:id', component: ProyectoComponent},
  { path: 'login', component: LoginComponent},
  { path: 'perfil', component: ProfileComponent},
  { path: 'registro', component: RegisterComponent},
  { path: 'user', component: BoardUserComponent},
  { path: 'admin', component: BoardAdminComponent},
  { path: '', redirectTo: 'home', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }