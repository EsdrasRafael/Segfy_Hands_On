import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { SeguroautoDetailsComponent } from './seguroauto-details/seguroauto-details.component';
import { SeguroautoDetailComponent } from './seguroauto-details/seguroauto-detail/seguroauto-detail.component';
import { SeguroautoDetailListComponent } from './seguroauto-details/seguroauto-detail-list/seguroauto-detail-list.component';

@NgModule({
  declarations: [
    AppComponent,
    SeguroautoDetailsComponent,
    SeguroautoDetailComponent,
    SeguroautoDetailListComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
