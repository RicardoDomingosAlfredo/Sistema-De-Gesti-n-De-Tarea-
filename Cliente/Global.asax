<%@ Application Language="C#" Inherits="System.Web.HttpApplication" %>

<script runat="server">
void Application_Start(object sender, EventArgs e) {
    // C�digo de inicializaci�n
    GlobalConfiguration.Configure(WebApiConfig.Register); // Configuraci�n de Web API
}
</script>
