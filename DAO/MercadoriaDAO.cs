using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MercadoriaDAO
    {
        public List<mercadoria> CarregarListaPesquisaMercadoria()
        {
            banco objBanco = new banco();
            List<mercadoria> lstRetorno = objBanco.mercadoria.ToList();

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
