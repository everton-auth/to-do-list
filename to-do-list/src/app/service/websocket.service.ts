import { Injectable } from '@angular/core';
import { HttpTransportType, HubConnectionBuilder, LogLevel } from '@microsoft/signalr';

@Injectable({
  providedIn: 'root'
})
export class Websocket {
  constructor() { }
  wsURI: string = "http://localhost:5098/chat";
  conexao = new HubConnectionBuilder().configureLogging(LogLevel.Debug).withAutomaticReconnect().withUrl(this.wsURI, {
    skipNegotiation: true,
    transport: HttpTransportType.WebSockets,
  }).build();

  messages: any[] = [];

  StartConnection() {
    this.conexao.on('SendMessage', (chat: string, message: string) => {
    })
    this.conexao.start();
  }
  EnviarMesnagem(message: string) {
    this.conexao.send("SendMessage", message);
    console.log(this.conexao.connectionId)
  }
}

