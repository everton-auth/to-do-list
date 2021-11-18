import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BootRoutingModule } from './boot-routing.module';


import { BootComponent } from './boot.component';


@NgModule({
  declarations: [
    BootComponent
  ],
  imports: [
    BrowserModule,
    BootRoutingModule
  ],
  providers: [],
  bootstrap: [BootComponent]
})
export class BootModule { }
