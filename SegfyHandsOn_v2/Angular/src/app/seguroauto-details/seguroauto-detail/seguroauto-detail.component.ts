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
      PMId: 0,
      NumeroApolice:null,
      CPF:'',
      PlacaVeiculo:'',
      ValorPremio:null
    }
  } 
  
  onSubmit(form:NgForm)
  {
    if(this.service.formData.PMId==0)
      this.insertRecord(form);
    else
    {
      this.updateRecord(form);
    }
  }
  insertRecord(form:NgForm)
  {
    this.service.postSeguroAuto()
      .subscribe(
        res=> {
          this.resetForm(form); 
          this.toastr.success('Cadastro efetuado', 'Seguro Auto Detail Register');
          this.service.refreshList();
        },
        err=>{
          console.log(err);
        }
      )
  }
  
  updateRecord(form:NgForm)
  {
    this.service.putSeguroAuto()
      .subscribe(
        res=> {
          this.resetForm(form); 
          this.toastr.info('Alteração efetuada', 'Seguro Auto Detail Register');
          this.service.refreshList();
        },
        err=>{
          console.log(err);
        }
      )
  }

  
}
