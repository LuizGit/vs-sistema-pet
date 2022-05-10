using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MercadoriaDAO
    {
        //Este método esta listando as mercadorias na tela 'fmrAjusteEstoque'
        public List<mercadoria> CarregarListaPesquisaMercadoria()
        {
            banco objBanco = new banco();
            List<mercadoria> lstRetorno = objBanco.mercadoria.ToList();

            return lstRetorno;
        }

        public List<mercadoria> PesquisaMercadoriaPorDescricao(string Desc)
        {
            banco objBanco = new banco();
            List<mercadoria> lstRetorno = objBanco.mercadoria.Where(m => m.Descricao.Contains(Desc)).ToList();

            return lstRetorno;
        }

        public void CadastrarMercadoria(mercadoria objMercadoria)
        {
            banco objBanco = new banco();

            objBanco.AddTomercadoria(objMercadoria);

            objBanco.SaveChanges();

        }
    }
}
