import { RouterModule } from '@angular/router';
import { MaterialModule } from './material/material.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  imports: [
    CommonModule
  ],
  exports: [
    MaterialModule,
    FlexLayoutModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
  ]
})
export class SharedModule { }
