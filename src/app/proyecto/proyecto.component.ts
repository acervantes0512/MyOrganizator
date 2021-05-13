import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProyectosService } from '../services/proyectos.service';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

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
  headerRow: string[];
  dataRows: string[][];

   frmproyecto: FormGroup;
   submitted = false;
   titulo = 'Editar Proyecto';

   public tableData1: TableData;
   public tableData2: TableData;
 

  constructor(private activateRoute: ActivatedRoute,
              private proyectoService: ProyectosService,
              private modalService: NgbModal,
              private formBuilder: FormBuilder
              ) {

    this.activateRoute.params.subscribe(params => {
      this.proyectoService.getProyecto(params['id']).subscribe(resp => {
        this.proyecto = resp.data;
        console.log(this.proyecto);
      });

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

    this.tableData1 = {
      headerRow: [ 'ID', 'Name', 'Country', 'City', 'Salary'],
      dataRows: [
          ['1', 'Dakota Rice', 'Niger', 'Oud-Turnhout', '$36,738'],
          ['2', 'Minerva Hooper', 'Curaçao', 'Sinaai-Waas', '$23,789'],
          ['3', 'Sage Rodriguez', 'Netherlands', 'Baileux', '$56,142'],
          ['4', 'Philip Chaney', 'Korea, South', 'Overland Park', '$38,735'],
          ['5', 'Doris Greene', 'Malawi', 'Feldkirchen in Kärnten', '$63,542'],
          ['6', 'Mason Porter', 'Chile', 'Gloucester', '$78,615']
      ]
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

  get f() { return this.frmproyecto.controls; }

  onSubmit() {
      this.submitted = true;

      if (this.frmproyecto.invalid) {
          return;
      }

      alert('Mensaje Enviado !')
  }

}
