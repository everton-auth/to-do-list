
import { SubscribeComponent } from './pages/subscribe/subscribe.component';
import { LoginComponent } from './pages/login/login.component';
import { UtilModule } from './../util/util.module';
import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthRoutingModule } from './Auth-routing.module';
import { _layoutComponent } from './pages/_layout/_layout.component';


@NgModule({
  declarations: [
    LoginComponent,
    SubscribeComponent,
    _layoutComponent,
  ],
  imports: [
    CommonModule,
    AuthRoutingModule,
    SharedModule,
    UtilModule,

  ]
})
export class AuthModule { }
