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
      console.log(chat)
    })
    this.conexao.start();
  }

  EnviarMesnagem(message: string) {
    this.conexao.send("SendMessagePrivate");
  }

  SendMessageToGroup(group: string, message: string) {
    this.conexao.send("SendMesssageToGroup", group, message)
  }

  SendMessagePrivate(user: string, message: string) {

  }

  AddToGroup(group: string, user: string) {
    this.conexao.send("AddToGroup", user, group)
  }
  createGroup(groupName: String) {
    this.conexao.send("CreateGroup", groupName)
  }
}

