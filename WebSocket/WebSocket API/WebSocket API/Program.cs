using WebSocket_API.Hubs;

var builder = WebApplication.CreateBuilder( args );

builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if( !app.Environment.IsDevelopment() ) {
    app.UseExceptionHandler( "/Error" );
}

app.UseRouting();

app.UseAuthorization();

app.UseWebSockets();

app.MapHub<coletorHub>( "/coletor" );
app.MapHub<chatHub>( "/chat" );
app.MapHub<TabelaHub>( "/Tabelas" );

app.Run();
