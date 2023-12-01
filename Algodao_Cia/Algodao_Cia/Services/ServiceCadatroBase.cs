using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Algodao_Cia.Services
{
    abstract class ServiceCadatroBase
    {
        protected abstract string UrlPost { get; }
        protected abstract string UrlGet { get; }
        protected abstract string UrlDelelte { get; }


        private HttpClient cliente;

        private StringContent ConvertParaJson(object entidade)
        {
            string json = JsonConvert.SerializeObject(entidade);
            return new StringContent(json, System.Text.Encoding.UTF8, "Aplication/Json");
        }


        protected async Task<HttpResponseMessage> PostHttp(object Entidade)
        {
            using (cliente = new HttpClient())
            {
                return await cliente.PostAsync(UrlPost, ConvertParaJson(Entidade));
            }
        }
    }
}
