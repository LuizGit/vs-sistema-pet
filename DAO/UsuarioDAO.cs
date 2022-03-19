using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAO
{
    public class UsuarioDAO
    {
        public bool LoginEntity(string login, string senha)
        {
            bool ret = true;
            banco objBanco = new banco();
            List<usuario> listaUsuario = objBanco.usuario.Where(u => u.Login == login).Where(s => s.Senha == senha).ToList();

            if (listaUsuario.Count() == 0)
            {
                ret = false;
            }
            else
            {
                ret = true;

            }
            return ret;
        }
        public void CadastrarUsuario(usuario usuario)
        {
            banco objBanco = new banco();

            objBanco.AddTousuario(usuario);

            objBanco.SaveChanges();
        }
    }
}
