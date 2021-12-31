import { SubscribeComponent } from './pages/subscribe/subscribe.component';
import { LoginComponent } from './pages/login/login.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { _layoutComponent } from './pages/_layout/_layout.component';

const routes: Routes = [
  {
    path: '',
    component: _layoutComponent,
    children: [
      {
        path: 'login',
        component: LoginComponent
      }, {
        path: 'subscriber',
        component: SubscribeComponent
      },
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AuthRoutingModule { }
