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
    }
}
