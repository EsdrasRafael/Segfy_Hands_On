import { Component, OnInit } from '@angular/core';
import { SeguroautoDetailService } from 'src/app/shared/seguroauto-detail.service';
import { NgForm } from '@angular/forms';
import { Toast, ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-seguroauto-detail',
  templateUrl: './seguroauto-detail.component.html',
  styles: []
})
export class SeguroautoDetailComponent implements OnInit {

  constructor(private service:SeguroautoDetailService, private toastr: ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?:NgForm)
  {
    if(form!=null)
    form.resetForm();
    this.service.formData = {
      PMId: null,
      NumeroApolice:null,
      CPF:'',
      PlacaVeiculo:'',
      ValorPremio:null
    }
  } onSubmit(form:NgForm)
  {
    this.service.postSeguroAuto(form.value)
.subscribe(
  res=> {
    this.resetForm(form); 
    this.toastr.success('Cadastro efetuado', 'SeguroAuto Detail Register');
  },
  err=>{
    console.log(err);
  }
 )  }

}
