import { Component, OnInit } from '@angular/core';
import { Websocket } from '../service/websocket.service';

@Component({
  selector: 'boot-root',
  templateUrl: './boot.component.html',
  styleUrls: ['./boot.component.scss']
})
export class BootComponent implements OnInit {

  mensagem: any;
  WebScoket: any;
  constructor(
    private ws: Websocket
  ) { }

  ngOnInit(): void {
    this.WebScoket = this.ws.startWS().subscribe((res: any) => { console.log(res) })
  }

  clicked() {
    this.ws.msg(this.WebScoket, this.mensagem);
  }
}
