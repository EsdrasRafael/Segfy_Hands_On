import { Component, OnInit } from '@angular/core';
import { SeguroautoDetailService } from 'src/app/shared/seguroauto-detail.service';
import { SeguroautoDetail } from 'src/app/shared/seguroauto-detail.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-seguroauto-detail-list',
  templateUrl: './seguroauto-detail-list.component.html',
  styles: []
})
export class SeguroautoDetailListComponent implements OnInit {

  constructor(private service:SeguroautoDetailService, private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(pd: SeguroautoDetail)
  {
    this.service.formData = Object.assign({}, pd);
  }
  onDelete(PMId)
  {
    if(confirm('Tem certeza que deseja deletar este registro ?')){
    this.service.deleteSeguroAuto(PMId)
    .subscribe(r=>{
      debugger;
      this.service.refreshList();
      this.toastr.warning('Exlusão realizada', 'Seguro Auto deletado')
    },
      err=>{
        debugger;
        console.log(err);
      })
  }
}
}
