using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioPNVO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public int IdPN { get; set; }
        public string NomeRazaoPN { get; set; }
        public string Senha { get; set; }
    }
}
