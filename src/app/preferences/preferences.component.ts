import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-preferences',
  templateUrl: './preferences.component.html',
  styleUrls: ['./preferences.component.css']
})
export class PreferencesComponent implements OnInit {

  frmTiposProyectos : FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit(): void {

    this.frmTiposProyectos = this.formBuilder.group({
      nombre: ['',Validators.required],
      descripcion: ['',Validators.required]
    })

  }

  onSubmitTiposProyectos(data){
    console.log("Entra al onSubmit");
  }

}
