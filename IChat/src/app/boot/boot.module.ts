import { UtilModule } from './../util/util.module';
import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { BootRoutingModule } from './boot-routing.module';
import { BootComponent } from './boot.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    BootComponent
  ],
  imports: [
    BrowserModule,
    BootRoutingModule,
    BrowserAnimationsModule,
    SharedModule,
    UtilModule,
    
  ],
  providers: [],
  bootstrap: [BootComponent]
})
export class BootModule { }
