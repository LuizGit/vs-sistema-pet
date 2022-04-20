using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAO
{
    public class TipoPetDAO
    {
        public List<tipopet> PesquisarTipoPet()
        {
            banco objBanco = new banco();
            List<tipopet> lstRetorno = objBanco.tipopet.ToList();

            return lstRetorno;
        }
        public void CadastrarEspecie(tipopet objTipo) {

            //Objeto que instancia todas as tabelas da classe referente ao banco.
            banco objbanco = new banco();

            //INFORMANDO QUAL SERá A A TABELA A TER VALOR INSERIDO.
            objbanco.AddTotipopet(objTipo);

            //Salva as alterações no banco.
            objbanco.SaveChanges();
        
        }

        public void AlterarEspecie (tipopet objAlterar)
        {

            banco objbanco = new banco();

            tipopet objTipoPet = objbanco.tipopet.Where(t => t.idTipoPet == objAlterar.idTipoPet).FirstOrDefault();

            objTipoPet.Descricao = objAlterar.Descricao;

            objbanco.SaveChanges();

        }


        public void ExcluirTipoPet(int idTipoPet)
        {

            banco ObjBanco = new banco();
            tipopet objDeletar = ObjBanco.tipopet.Where(p => p.idTipoPet == idTipoPet).FirstOrDefault();

            ObjBanco.DeleteObject(objDeletar);

            ObjBanco.SaveChanges();
}



    }
}
