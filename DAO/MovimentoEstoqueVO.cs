using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MovimentoEstoqueVO
    {
        public int idMovimento { get; set; }
        public decimal Quantidade { get; set; }
        public int idMercadoria { get; set; }
        public String EntradaSaida { get; set; }
        public string Descricao { get; set; }
        public string CodBarras { get; set; }
        public decimal Preco { get; set; }

    }
}
