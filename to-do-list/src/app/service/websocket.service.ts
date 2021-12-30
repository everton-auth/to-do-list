import { Injectable } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@microsoft/signalr';

@Injectable({
  providedIn: 'root'
})
export class Websocket {
  constructor() { }
  wsURI: string = "http://localhost:5000/teste";
  conexao = new HubConnectionBuilder().withUrl(this.wsURI).build();
  messages: any[] = [];

  StartConnection() {
    this.conexao.on('newMessage', (chat: string, message: string) => {
      this.messages.push({
        text: message,
        user: chat
      })
    })
    console.log(this.conexao.state);
    this.conexao.start();
  }
  EnviarMesnagem(mensagem: string) {
   this.conexao.send("newMessage", mensagem);
  }
}

