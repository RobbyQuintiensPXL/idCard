using idCardXF.Services;
using idCardXF.Droid;
using System.Net.Http;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(HttpClientHandlerService))]
namespace idCardXF.Droid
{
    public class HttpClientHandlerService : IHttpClientHandlerService
    {
        public HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }
    }
}