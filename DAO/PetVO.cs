using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PetVO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Descricao { get; set; }
        public int IdPN { get; set; }
        public string NomeRazao { get; set; }
        public int IdTipo { get; set; }
        public string DescricaoTipo { get; set; }
        public int IdPorte { get; set; }
        public string DescricaoPorte { get; set; }
        public string Sexo { get; set; }
        public int Castrado { get; set; }
        public DateTime DtNascimento { get; set; }
        
    }
}
