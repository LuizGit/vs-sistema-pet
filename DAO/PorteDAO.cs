using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PorteDAO
    {
        public List<porte> PesquisarPorte()
        {
            banco objBanco = new banco();
            List<porte> lstRetorno = objBanco.porte.ToList();

            return lstRetorno;
        }
    }
}
