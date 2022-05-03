using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Threading.Tasks;
using System.Web.Http;

[assembly: OwinStartup(typeof(ServicioWCFRest.Startup))]

namespace ServicioWCFRest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            HttpConfiguration config = new HttpConfiguration();
            //WebApiConfig.Register(config);
            ConfigurationOauth(app);
        }


        private void ConfigurationOauth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions opcionesAutorizacion = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/recuperatoken"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(1),
                // Provider = new Credentials.

            };
            app.UseOAuthAuthorizationServer(opcionesAutorizacion);
            OAuthBearerAuthenticationOptions opcionesoauth = new OAuthBearerAuthenticationOptions()
            {
                AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Active
            };

            app.UseOAuthBearerAuthentication(opcionesoauth);
        
          
        }
    }
}
