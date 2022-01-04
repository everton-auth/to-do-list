import { ChatComponent } from './chat/chat.component';
import { LayoutComponent } from './Layout/Layout.component';
import { CommonsModule } from './../commons/commons.module';
import { UtilModule } from './../../util/util.module';
import { SharedModule } from './../../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CoreRoutingModule } from './core-routing.module';


@NgModule({
  declarations: [
    LayoutComponent,
    ChatComponent,
  ],
  imports: [
    CommonModule,
    CoreRoutingModule,
    SharedModule,
    UtilModule,
    CommonsModule
  ]
})
export class CoreModule { }
