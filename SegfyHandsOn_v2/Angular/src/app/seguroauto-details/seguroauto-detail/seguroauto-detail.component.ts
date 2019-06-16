import { Component, OnInit } from '@angular/core';
import { SeguroautoDetailService } from 'src/app/shared/seguroauto-detail.service';

@Component({
  selector: 'app-seguroauto-detail',
  templateUrl: './seguroauto-detail.component.html',
  styles: []
})
export class SeguroautoDetailComponent implements OnInit {

  constructor(private service:SeguroautoDetailService) { }

  ngOnInit() {
  }

}
