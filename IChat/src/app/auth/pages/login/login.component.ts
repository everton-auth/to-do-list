import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  UserLogin!: FormGroup;
  hide: any;

  constructor(
    private _FormBuider: FormBuilder
  ) { }

  ngOnInit() {
    this.UserLogin = this._FormBuider.group({
      DT_Email: [null, Validators.required],
      DT_Password: [null, Validators.required]
    })
  }
  onLogin() {
    console.log(this.UserLogin)
  }

}
