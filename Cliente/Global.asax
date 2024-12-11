<%@ Application Language="C#" Inherits="System.Web.HttpApplication" %>

<script runat="server">
void Application_Start(object sender, EventArgs e) {
    // Código de inicialización
    GlobalConfiguration.Configure(WebApiConfig.Register); // Configuración de Web API
}
</script>
