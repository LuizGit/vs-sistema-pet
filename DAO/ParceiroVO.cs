using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ParceiroVO
    {
        public int IdParceiroNegocio { get; set; }
        public string NomeRazao { get; set; }
        public string CpfCnpj { get; set; }
        public int TipoPN { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public int Ativo { get; set; }
        public int Pet { get; set; }
        public int Usuario { get; set; }
        public parceironegocio ObjParceironegocio { get; set; }

    }
}
