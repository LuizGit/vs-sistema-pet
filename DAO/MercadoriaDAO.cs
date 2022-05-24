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


        public void CadastrarMercadoria(mercadoria objMercadoria)
        {
            banco objBanco = new banco();

            objBanco.AddTomercadoria(objMercadoria);

            objBanco.SaveChanges();

        }


        public void ExcluirMercadoria(int idDescricao)
        {

            banco ObjBanco = new banco();
            mercadoria objDeletar = ObjBanco.mercadoria.Where(p => p.idMercadoria == idDescricao).FirstOrDefault();

            ObjBanco.DeleteObject(objDeletar);

            ObjBanco.SaveChanges();
        }


        public void AlterarMercadoria(mercadoria objAlterar)
        {

            banco objbanco = new banco();

            mercadoria objmercadoria  = objbanco.mercadoria.Where(t => t.idMercadoria == objAlterar.idMercadoria).FirstOrDefault();

            objmercadoria.Descricao = objAlterar.Descricao;
            objmercadoria.CodBarras = objAlterar.CodBarras;
            objmercadoria.Preco = objAlterar.Preco;

            objbanco.SaveChanges();

        }

        public List<mercadoria> PesquisarCampoDescricao(string NomeRazao)
        {
            banco objBanco = new banco();

            List<mercadoria> lstRetorno = objBanco.mercadoria.Where(p => p.Descricao.Contains(NomeRazao)).ToList();

            return lstRetorno;
        }




    }
}
