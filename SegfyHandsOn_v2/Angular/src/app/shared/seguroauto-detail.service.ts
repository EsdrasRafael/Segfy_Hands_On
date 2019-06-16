import { Injectable } from '@angular/core';
import { SeguroautoDetail } from './seguroauto-detail.model';

@Injectable({
  providedIn: 'root'
})
export class SeguroautoDetailService {
  formData:SeguroautoDetail
  constructor() { }
}
