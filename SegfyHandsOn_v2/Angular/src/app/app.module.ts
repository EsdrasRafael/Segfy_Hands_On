import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { SeguroautoDetailsComponent } from './seguroauto-details/seguroauto-details.component';
import { SeguroautoDetailComponent } from './seguroauto-detail/seguroauto-detail/seguroauto-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    SeguroautoDetailsComponent,
    SeguroautoDetailComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
