using JsonServices;
using JsonServices.Web;

namespace wResAPI_d3xd
{
    public class Handler1 : JsonHandler
    {
        public Handler1()
        {  
            this.service.Name = "WebAPI_Retail";
            this.service.Description = "WebAPI para leer Base Datos";
            InterfaceConfiguration IConfig = new InterfaceConfiguration("RestAPI", typeof(IServiceAPI), typeof(ServiceAPI));
            this.service.Interfaces.Add(IConfig);
        }

    }
}