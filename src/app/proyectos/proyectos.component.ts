import { Component, OnInit } from '@angular/core';
import { ProyectosService } from '../services/proyectos.service';
import {Response } from '../Models/response';
import { TipoProyectoService } from '../services/tipo-proyecto.service';
import { TokenStorageService } from '../services/token-storage.service';
import { Router } from '@angular/router';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TransversalService } from '../services/transversal.service';
import { IProyecto } from '../shared/models/IProyecto';

@Component({
  selector: 'app-proyectos',
  templateUrl: './proyectos.component.html',
  styleUrls: ['./proyectos.component.css']
})
export class ProyectosComponent implements OnInit {

  public lst: any[];
  closeResult: string;
  frmproyecto: FormGroup;
  public tiposProyectos: any[];
  modelFechaInicio;
  modelFechaFin;


  constructor(
              private proyectosService: ProyectosService,
              private tipoProyectoService: TipoProyectoService,
              private tokenStorage: TokenStorageService,
              private transversalService: TransversalService,
              private modalService: NgbModal,
              private router: Router,
              private formBuilder: FormBuilder
            )
   {

    if(!this.tokenStorage.getUser()){
      this.router.navigate(['/login']);
    }else{
      this.getProyectos();
    }


   }

  ngOnInit(): void {

    this.frmproyecto = this.formBuilder.group({
      nombreProyecto: ['', Validators.required],
      descripcionProyecto: ['', Validators.required],
      etiquetas: ['', Validators.required],
      porcentajeAsignacion: ['', Validators.required],
      tipoProyecto: ['', Validators.required],
      fechaInicio: ['', Validators.required],
      fechaFin: ['', Validators.required],
      usuario: ['', Validators.required]
    });
    this.obtenerTiposProyecto();
  }

  getProyectos(){
    var usuario = window.sessionStorage.getItem('username');
    this.proyectosService.getProyectos(usuario).subscribe( response => {
      this.lst = response.data;
      //this.getNombreTipoProyecto();
    })
  }

  getNombreTipoProyecto(idProyecto:number){

    console.log(this.lst);

    for(var el of this.lst){

      this.tipoProyectoService.getTipoProyecto(idProyecto).subscribe( resp => {
        console.log(resp);


        return resp.data.name;
        //el.push(tipo) = "tipoo";
        //console.log(this.lst);
      });

    }

  }

  open(content) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title', size:'lg'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
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

  obtenerTiposProyecto(){
    this.transversalService.obtenerTiposProyectos().subscribe(x => {
      this.tiposProyectos = x.data;
    })
  }

  onSubmit(datos){
    var x = datos['fechaInicio'];
    var fechaI = x['day']+'/'+x['month']+'/'+x['year'];
    x = datos['fechaFin'];
    var fechaF = x['day']+'/'+x['month']+'/'+x['year'];
    datos.fechaInicio = fechaI;
    datos.fechaFin = fechaF;

    datos.usuario = window.sessionStorage.getItem('username');

    this.proyectosService.crearProyecto(datos).subscribe(x => {
      this.frmproyecto.reset();
      this.modalService.dismissAll();
      this.getProyectos();
      
    })
  }

  eliminarProyecto(indexProyecto:number){
    var proyecto = this.lst[indexProyecto];
    this.proyectosService.eliminarProyecto(proyecto.idProyecto).subscribe( response => {
      this.getProyectos();
    })

  }

}
