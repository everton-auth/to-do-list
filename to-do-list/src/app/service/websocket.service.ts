import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { webSocket } from "rxjs/webSocket";

@Injectable({
  providedIn: 'root'
})
export class Websocket {
  constructor() { }
  wsURI: string = "ws://10.0.0.233:5000/ws";

  startWS() {
    return webSocket(this.wsURI)
  }

  msg(subject: Subject<any>, mensagem: string) {
    subject.next(mensagem);
  }
}

