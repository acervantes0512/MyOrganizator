import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TipoProyectoService } from '../services/tipo-proyecto.service';
import { TransversalService } from '../services/transversal.service';

@Component({
  selector: 'app-preferences',
  templateUrl: './preferences.component.html',
  styleUrls: ['./preferences.component.css']
})
export class PreferencesComponent implements OnInit {

  frmTiposProyectos : FormGroup;
  listaTiposProyectos: any;

  constructor(private formBuilder: FormBuilder,
              private transversalesService: TransversalService,
              private tiposProyectosService: TipoProyectoService) { }

  ngOnInit(): void {

    this.frmTiposProyectos = this.formBuilder.group({
      nombre: ['',Validators.required],
      descripcion: ['',Validators.required]
    });

    this.actualizarListaTiposProyectos();

  }

  onSubmitTiposProyectos(data){
    data.username = window.sessionStorage.getItem('username');
    this.transversalesService.crearTipoProyecto(data).subscribe(resp => {
      this.frmTiposProyectos.reset();
      this.actualizarListaTiposProyectos();
    });
  }

  private actualizarListaTiposProyectos(){
    this.transversalesService.obtenerTiposProyectos(window.sessionStorage.getItem('username')).subscribe( resp => {
      this.listaTiposProyectos = resp.data;
      debugger
    });
  }

}
