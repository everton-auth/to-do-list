import { Component, OnInit } from '@angular/core';
import { Websocket } from '../service/websocket.service';

@Component({
  selector: 'boot-root',
  templateUrl: './boot.component.html',
  styleUrls: ['./boot.component.scss']
})
export class BootComponent implements OnInit {

  mensagem: any;
  Conexao: any;
  constructor(
    private ws: Websocket
  ) { }

  ngOnInit(): void {
    this.Conexao = this.ws.StartConnection();
  }
  
  clicked() {
    this.Conexao = this.ws.EnviarMesnagem('olá');
  }
}
