import { Injectable } from '@angular/core';
import { SeguroautoDetail } from './seguroauto-detail.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class SeguroautoDetailService {
  formData:SeguroautoDetail
  readonly rootUrl = 'http://localhost:5000/api';
  list : SeguroautoDetail[]; 

  constructor(private http:HttpClient) { }

  postSeguroAuto(formData:SeguroautoDetail)
  {
    return this.http.post(this.rootUrl+'/SeguroAuto', formData);
  }
  refreshList(){
    this.http.get(this.rootUrl+'/SeguroAuto')
    .toPromise()
    .then(res=> this.list = res as SeguroautoDetail[]); 
  }
}
