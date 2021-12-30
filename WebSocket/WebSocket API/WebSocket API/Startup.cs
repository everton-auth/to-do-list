using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSocket_API {
    public class Startup {
        public Startup( IConfiguration configuration ) {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        readonly string CorsPolicy = "CorsPolicy";

        public void ConfigureServices( IServiceCollection services ) {
            services.AddCors( options => {
                options.AddPolicy( CorsPolicy ,
                        builder => {
                            builder                          
                                .WithOrigins( "*", "*", "*" );
                                
                        } );

            } );
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app , IWebHostEnvironment env ) {
            if( env.IsDevelopment() ) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler( "/Error" );
            }
            app.UseCors();
            app.UseRouting();

            app.UseWebSockets();

            app.UseEndpoints( endpoints => {
                endpoints.MapHub<GrupoHub>( "/coletor" );
                endpoints.MapHub<Chat>( "/Chat" );
                endpoints.MapHub<testeHub>( "/teste" );
            } );
        }
    }
}
