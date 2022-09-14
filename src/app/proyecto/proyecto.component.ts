import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProyectosService } from '../services/proyectos.service';
import {NgbModal, ModalDismissReasons, NgbDate} from '@ng-bootstrap/ng-bootstrap';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActividadesService } from '../services/actividades.service';
import { TransversalService } from '../services/transversal.service';
import { IProyecto } from '../shared/models/IProyecto';
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
  modelFechaFinAct
  modelFechaInicioAct
  frmActividad: FormGroup;
  isUpdatingActivity: boolean;
  public headerRow: string[];
  dataRows: string[][];
  public listaActividades : any[];
  public listaTiposTiempo: any[];
  public listaTiposActividad: any[];
  public tiposProyectos: any[];
   frmproyectoEditar: FormGroup;
   submitted = false;
   titulo = 'Editar Proyecto';

   public tableData1: TableData;
   public tableData2: TableData;
 

  constructor(private activateRoute: ActivatedRoute,
              private proyectoService: ProyectosService,
              private actividadesService: ActividadesService,
              private transversalService: TransversalService,
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

    this.frmproyectoEditar = this.formBuilder.group({
      nombreProyecto: ['', Validators.required],
      descripcionProyecto: ['', Validators.required],
      etiquetas: ['', Validators.required],
      porcentajeAsignacion: ['', Validators.required],      
      fechaInicio: ['', Validators.required], 
      fechaFin: ['', Validators.required],
      tipoProyecto: ['', Validators.required]
    });

    this.frmActividad = this.formBuilder.group({
      nombreActividad: ['', Validators.required],
      descripcion: ['', Validators.required],
      duracionMinutos: ['', Validators.required],
      fechaInicio: ['', Validators.required],
      fechaFin: ['', Validators.required],
      idTipoTiempo: ['', Validators.required],
      idTipoActividad: ['', Validators.required],
      IdActividad: ['', Validators.required]
    })


    this.headerRow = [ 'Nombre', 'Descripción', 'Duración', 'Fecha Inicio', 'Fecha Fin', 'Acciones'];
    this.obtenerTiposTiempo();
    this.obtenerTiposActividad(); 
    this.obtenerTiposProyectos(); 
    this.isUpdatingActivity = false;    
  }

  openModalUpdateActivity(contentModal ,idActividad:number){
    this.isUpdatingActivity = true;
    var actividad = this.listaActividades.find(x => x.planActividadId = idActividad);
    this.setearDataModalActivities(actividad);
    this.open(contentModal);
  }

  openModalUpdateProject(contentModal){
    this.setearDatosModal();
    this.open(contentModal);
  }

  setearDataModalActivities(actividad){
    this.frmActividad.reset();   
    var dtInitial = new Date(actividad.fechaInicio);
    var fechaInicial = new NgbDate(dtInitial.getFullYear(),dtInitial.getMonth()+1,dtInitial.getDate());

    var dtFinal = new Date(actividad.fechaFin);
    var fechaFinal = new NgbDate(dtFinal.getFullYear(),dtFinal.getMonth()+1,dtFinal.getDate());

    this.frmActividad.controls["nombreActividad"].setValue(actividad.nombre);
    this.frmActividad.controls["descripcion"].setValue(actividad.descripcion);
    this.frmActividad.controls["duracionMinutos"].setValue(actividad.duracionMinutos);
    this.frmActividad.controls["idTipoTiempo"].setValue(actividad.tipoTiempoId);
    this.frmActividad.controls["idTipoActividad"].setValue(actividad.tipoActividadId);
    this.frmActividad.controls["IdActividad"].setValue(actividad.planActividadId);
    this.modelFechaInicioAct = fechaInicial;
    this.modelFechaFinAct = fechaFinal;

  }

  open(content) {       
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title', size:'lg'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  obtenerActividadesPorProyecto(proyectoId:string){
    this.actividadesService.obtenerActividadesPorProyecto(proyectoId).subscribe( response => {
      this.listaActividades = response.data;
    })
  }

  obtenerTiposTiempo(){
    this.transversalService.obtenerTiposTiempo().subscribe(x => {
      this.listaTiposTiempo = x.data;
    });
  }

  obtenerTiposActividad(){
    this.transversalService.obtenerTiposActividad().subscribe(x => {
      this.listaTiposActividad = x.data;
    });
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

  get f() { return this.frmproyectoEditar.controls; }

  onSubmit(result) {

      var modl = this.modelFechaInicio;
      var x = result['fechaInicio'];
      var fechaI = x['day']+'/'+x['month']+'/'+x['year'];
      x = result['fechaFin'];
      var fechaF = x['day']+'/'+x['month']+'/'+x['year'];
      result.fechaInicio = fechaI;
      result.fechaFin = fechaF;
      result.usuario = window.sessionStorage.getItem('username'); //TODO Mejorar implementación para leer NgbDate
      result.proyectoId = this.proyecto.proyectoId;

      this.proyectoService.actualizarProyecto(result).subscribe(x => {
        this.frmproyectoEditar.reset();
        this.modalService.dismissAll(); 
        this.obtenerProyecto(this.proyecto.proyectoId);       
      })
  }

  private setearDatosModal(){  

      var dtInitial = new Date(this.proyecto.fechaInicio);
      var fechaInicial = new NgbDate(dtInitial.getFullYear(),dtInitial.getMonth()+1,dtInitial.getDate());

      var dtFinal = new Date(this.proyecto.fechaFin);
      var fechaFinal = new NgbDate(dtFinal.getFullYear(),dtFinal.getMonth()+1,dtFinal.getDate());

      this.frmproyectoEditar.controls["nombreProyecto"].setValue(this.proyecto.nombre)
      this.frmproyectoEditar.controls["descripcionProyecto"].setValue(this.proyecto.descripcion)
      this.frmproyectoEditar.controls["etiquetas"].setValue(this.proyecto.etiqueta)
      this.frmproyectoEditar.controls["porcentajeAsignacion"].setValue("50") //TODO Cambiar porcentaje de asignación quemado
      this.modelFechaInicio = fechaInicial;
      this.modelFechaFin = fechaFinal;
      this.frmproyectoEditar.controls["tipoProyecto"].setValue(this.proyecto.tipoProyectoId)      
  }

  obtenerProyecto(proyectoId:number){
    this.proyectoService.getProyecto(proyectoId).subscribe( x => {
      this.proyecto = x.data;
    })
  }

  obtenerTiposProyectos(){
    let usuario:string = window.sessionStorage.getItem('username');
    this.transversalService.obtenerTiposProyectos(usuario).subscribe(x => {
      this.tiposProyectos = x.data;
    })
  }

  onSubmitCrearActividad(dataActividad){
    var modl = this.modelFechaInicio;
    var x = dataActividad['fechaInicio'];
    var fechaI = x['day']+'/'+x['month']+'/'+x['year'];
    x = dataActividad['fechaFin'];
    var fechaF = x['day']+'/'+x['month']+'/'+x['year'];
    dataActividad.fechaInicio = fechaI;
    dataActividad.fechaFin = fechaF;
    dataActividad.IdProyecto = this.proyecto.proyectoId.toString();

    this.actividadesService.crearActividad(dataActividad).subscribe(x => {
      this.frmActividad.reset();
      this.modalService.dismissAll();
      this.obtenerActividadesPorProyecto(this.proyecto.proyectoId);
    })
  }

  onSubmitEditarActividad(dataActividad){  
    debugger  
    var modl = this.modelFechaInicio;
    var x = dataActividad['fechaInicio'];
    var fechaI = x['day']+'/'+x['month']+'/'+x['year'];
    x = dataActividad['fechaFin'];
    var fechaF = x['day']+'/'+x['month']+'/'+x['year'];
    dataActividad.fechaInicio = fechaI;
    dataActividad.fechaFin = fechaF;
    dataActividad.IdProyecto = this.proyecto.proyectoId.toString();  

    this.actividadesService.editarActividad(dataActividad).subscribe(x => {
      this.frmActividad.reset();
      this.modalService.dismissAll();
      this.obtenerActividadesPorProyecto(this.proyecto.proyectoId);
    }, err => {
      debugger
      console.log("Error Capturado==>"+err);
    })
  }

  onSubmitModalActivity(content){
    if(!this.isUpdatingActivity){
      this.onSubmitCrearActividad(content);
    }
    else
    {
      this.onSubmitEditarActividad(content);
    }
  }

}
