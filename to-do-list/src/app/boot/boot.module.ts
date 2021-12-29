import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BootRoutingModule } from './boot-routing.module';


import { BootComponent } from './boot.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SharedModule } from '../Shared/Shared/Shared.module';


@NgModule({
  declarations: [
    BootComponent
  ],
  imports: [
    BrowserModule,
    BootRoutingModule,
    FormsModule,
    BrowserAnimationsModule,
    SharedModule,
    
  ],
  providers: [],
  bootstrap: [BootComponent]
})
export class BootModule { }
