import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";

import { AppComponent } from './app.component';
import { SeguroautoDetailsComponent } from './seguroauto-details/seguroauto-details.component';
import { SeguroautoDetailComponent } from './seguroauto-details/seguroauto-detail/seguroauto-detail.component';
import { SeguroautoDetailListComponent } from './seguroauto-details/seguroauto-detail-list/seguroauto-detail-list.component';
import { SeguroautoDetailService } from './shared/seguroauto-detail.service';

@NgModule({
  declarations: [
    AppComponent,
    SeguroautoDetailsComponent,
    SeguroautoDetailComponent,
    SeguroautoDetailListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [SeguroautoDetailService],
  bootstrap: [AppComponent]
})
export class AppModule { }
