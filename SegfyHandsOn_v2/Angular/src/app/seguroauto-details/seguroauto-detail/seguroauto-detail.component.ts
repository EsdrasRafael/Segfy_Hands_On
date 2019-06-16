import { Component, OnInit } from '@angular/core';
import { SeguroautoDetailService } from 'src/app/shared/seguroauto-detail.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-seguroauto-detail',
  templateUrl: './seguroauto-detail.component.html',
  styles: []
})
export class SeguroautoDetailComponent implements OnInit {

  constructor(private service:SeguroautoDetailService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?:NgForm)
  {
    if(form!=null)
    form.resetForm();
    this.service.formData = {
      PMId: 0,
      NumeroApolice:0,
      CPF:'',
      PlacaVeiculo:'',
      ValorPremio:0
    }
  } onSubmit(form:NgForm)
  {
    this.service.postSeguroAuto(form.value)
.subscribe(
  res=> {
    this.resetForm(form); 
  },
  err=>{
    console.log(err);
  }
 )  }

}
