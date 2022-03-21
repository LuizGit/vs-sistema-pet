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
        public List<UsuarioPNVO> CarrgarUsuariosCadastrados()
        {
            banco objBanco = new banco();
            List<UsuarioPNVO> lstRetorno = new List<UsuarioPNVO>();
            List<usuario> lstConsulta = objBanco.usuario.Include("parceironegocio").ToList();

            for (int i = 0; i < lstConsulta.Count(); i++)
            {

                UsuarioPNVO objUPN = new UsuarioPNVO();

                objUPN.Id = lstConsulta[i].idUsuario;
                objUPN.Login = lstConsulta[i].Login;
                objUPN.IdPN = lstConsulta[i].parceironegocio.idParceiroNegocio;
                objUPN.NomeRazaoPN = lstConsulta[i].parceironegocio.NomeRazao;
                objUPN.Senha = lstConsulta[i].Senha;

                lstRetorno.Add(objUPN);

            }
            return lstRetorno;
        }
    }
}
