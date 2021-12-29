﻿using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WS.Client {
    internal class Program {
        static async Task Main( string[] args ) {
            Console.WriteLine( "Pressione Enter para continuar..." );
            Console.ReadLine();

            using( ClientWebSocket Client = new ClientWebSocket() ) {
                Uri serviceUri = new Uri( "ws://localhost:5000/ws" );

                var cTs = new CancellationTokenSource();
                cTs.CancelAfter( TimeSpan.FromSeconds( 120 ) );
                try {
                    await Client.ConnectAsync( serviceUri , cTs.Token );
                    var n = 0;
                    while( Client.State == WebSocketState.Open ) {
                        Console.WriteLine( "Escreva sua mensagem" );
                        string message = Console.ReadLine();
                        if( !string.IsNullOrEmpty( message ) ) {
                            ArraySegment<byte> byteToSend = new ArraySegment<byte>( Encoding.UTF8.GetBytes( message ) );
                            await Client.SendAsync( byteToSend , WebSocketMessageType.Text , true , cTs.Token );
                            var responseBuffer = new byte[ 1024 ];
                            var offset = 0;
                            var packet = 1024;
                            while( true ) {
                                ArraySegment<byte> byteRecieved = new ArraySegment<byte>( responseBuffer , offset , packet );
                                WebSocketReceiveResult response = await Client.ReceiveAsync( byteRecieved , cTs.Token );
                                var responseMessage = Encoding.UTF8.GetString( responseBuffer , offset , response.Count );

                                Console.WriteLine( responseMessage );
                                if( response.EndOfMessage )
                                    break;


                            }

                        }
                    }
                } catch( WebSocketException e ) {
                    Console.WriteLine( e.Message );
                }


            }
            Console.ReadLine();
        }
    }
}
