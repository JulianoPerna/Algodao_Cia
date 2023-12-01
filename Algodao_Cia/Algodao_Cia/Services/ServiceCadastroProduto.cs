using Algodao_Cia.Inteface;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Algodao_Cia.Services
{
    internal class ServiceCadastroProduto : ServiceCadatroBase, IServiceCadastroClient
    {

        

        protected override string UrlPost { get => throw new NotImplementedException(); }
        protected override string UrlGet { get => throw new NotImplementedException(); }
        protected override string UrlDelelte { get => throw new NotImplementedException(); }

        public object ObterEntidadePorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> ObterListaEntidadeAtiva()
        {
            throw new NotImplementedException();
        }

        public async void Salvar(object Entidade)
        {
            await this.PostHttp(Entidade);
        }




    }
}
