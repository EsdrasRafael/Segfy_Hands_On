import { Component, OnInit } from '@angular/core';
import { SeguroautoDetailService } from 'src/app/shared/seguroauto-detail.service';

@Component({
  selector: 'app-seguroauto-detail-list',
  templateUrl: './seguroauto-detail-list.component.html',
  styles: []
})
export class SeguroautoDetailListComponent implements OnInit {

  constructor(private service:SeguroautoDetailService) { }

  ngOnInit() {
    this.service.refreshList();
  }

}
