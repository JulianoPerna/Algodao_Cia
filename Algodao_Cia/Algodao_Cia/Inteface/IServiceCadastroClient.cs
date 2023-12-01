using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Algodao_Cia.Inteface
{
    public interface IServiceCadastroClient
    {
        void Salvar(object Entidade);
        Task<List<Object>> ObterListaEntidadeAtiva();
        object ObterEntidadePorId(int Id);


    }
}
