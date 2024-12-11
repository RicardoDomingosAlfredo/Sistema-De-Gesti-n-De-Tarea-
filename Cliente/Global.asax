using System.Web.Http;

public class WebApiConfig
{
    public static void Register(HttpConfiguration config)
    {
        // Configura rutas de la API REST
        config.MapHttpAttributeRoutes();

        // Rutas predeterminadas de la API
        config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
        );
    }
}

// En el método Application_Start, agrega:
protected void Application_Start()
{
    GlobalConfiguration.Configure(WebApiConfig.Register);
}
