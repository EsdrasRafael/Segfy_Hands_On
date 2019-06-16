import { Injectable } from '@angular/core';
import { SeguroautoDetail } from './seguroauto-detail.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class SeguroautoDetailService {
  formData:SeguroautoDetail
  readonly rootUrl = 'http://localhost:5000/api';

  constructor(private http:HttpClient) { }

  postSeguroAuto(formData:SeguroautoDetail)
  {
    return this.http.post(this.rootUrl+'/SeguroAuto', formData);
  }
}
