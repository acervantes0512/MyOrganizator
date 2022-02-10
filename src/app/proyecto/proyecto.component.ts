import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProyectosService } from '../services/proyectos.service';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActividadesService } from '../services/actividades.service';

declare interface TableData {
  headerRow: string[];
  dataRows: string[][];
}

@Component({
  selector: 'app-proyecto',
  templateUrl: './proyecto.component.html',
  styleUrls: ['./proyecto.component.css']
})
export class ProyectoComponent implements OnInit {

  proyecto:any;
  title = 'appBootstrap';
  closeResult: string;
  model;
  modelActividades;
  modelFechaInicio;
  modelFechaFin;
  public headerRow: string[];
  dataRows: string[][];
  public listaActividades : any[];

   frmproyecto: FormGroup;
   submitted = false;
   titulo = 'Editar Proyecto';

   public tableData1: TableData;
   public tableData2: TableData;
 

  constructor(private activateRoute: ActivatedRoute,
              private proyectoService: ProyectosService,
              private actividadesService: ActividadesService,
              private modalService: NgbModal,
              private formBuilder: FormBuilder
              ) {

    this.activateRoute.params.subscribe(params => {
      this.proyectoService.getProyecto(params['id']).subscribe(resp => {
        this.proyecto = resp.data;
        console.log(this.proyecto);
      });

      this.obtenerActividadesPorProyecto(params['id']);

    })

   }

  ngOnInit(): void {

    this.frmproyecto = this.formBuilder.group({
      nombreProyecto: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      asunto: ['', Validators.required],
      tipoProyecto: ['', Validators.required],
      mensaje: ['', [Validators.required, Validators.minLength(6)]]
    });

    this.headerRow = [ 'Nombre', 'Descripción', 'Duración', 'Fecha Inicio', 'Fecha Fin'];

  }

  open(content) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title', size:'lg'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  obtenerActividadesPorProyecto(idProyecto:string){
    this.actividadesService.obtenerActividadesPorProyecto(idProyecto).subscribe( response => {
      this.listaActividades = response.data;
    })
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return  `with: ${reason}`;
    }
  }

  get f() { return this.frmproyecto.controls; }

  onSubmit() {
      this.submitted = true;

      if (this.frmproyecto.invalid) {
          return;
      }

      alert('Mensaje Enviado !')
  }

}
