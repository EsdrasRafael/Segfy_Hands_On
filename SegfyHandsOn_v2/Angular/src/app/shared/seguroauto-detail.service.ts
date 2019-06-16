import { Injectable } from '@angular/core';
import { SeguroautoDetail } from './seguroauto-detail.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class SeguroautoDetailService {
  formData:SeguroautoDetail;
  readonly rootUrl = 'http://localhost:5000/api';
  list : SeguroautoDetail[]; 

  constructor(private http:HttpClient) { }

  postSeguroAuto()
  {
    return this.http.post(this.rootUrl+'/SeguroAuto', this.formData);
  }
  putSeguroAuto()
  {
    return this.http.put(this.rootUrl+'/SeguroAuto/'+ this.formData.Id, this.formData);
  }
  deleteSeguroAuto(id)
  {
    return this.http.delete(this.rootUrl+'/SeguroAuto/'+ id);
  }
  refreshList(){
    this.http.get(this.rootUrl +'/SeguroAuto')
    .toPromise()
    .then(res=> this.list = res as SeguroautoDetail[]); 
  }
}
