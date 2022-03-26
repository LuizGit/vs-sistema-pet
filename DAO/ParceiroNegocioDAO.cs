using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ParceiroNegocioDAO
    {
        public void InserirParceiro(parceironegocio objParceiro)
        {
            banco objBanco = new banco();

            objBanco.AddToparceironegocio(objParceiro);

            objBanco.SaveChanges();

        }
        
        public List<parceironegocio> ConsultarParceiros()
        {
            banco objBanco = new banco();

            List<parceironegocio> lstRetorno = objBanco.parceironegocio.Where(p => p.Ativo == 1).ToList();

            return lstRetorno;
        }
        public void AlterarParceiro(parceironegocio objPN)
        {
            banco objBanco = new banco();

            parceironegocio objAlterar = objBanco.parceironegocio.Where(p => p.idParceiroNegocio == objPN.idParceiroNegocio).FirstOrDefault();

            objAlterar.NomeRazao = objPN.NomeRazao;
            objAlterar.CpfCnpj = objPN.CpfCnpj;
            objAlterar.TipoPN = objPN.TipoPN;
            objAlterar.Logradouro = objPN.Logradouro ;
            objAlterar.Bairro = objPN.Bairro;
            objAlterar.Cidade = objPN.Cidade;
            objAlterar.Estado = objPN.Estado;
            objAlterar.Contato = objPN.Contato;
            objAlterar.email = objPN.email;
            objAlterar.Ativo = objPN.Ativo;

            objBanco.SaveChanges();
        }
        public void InativarParceiro(parceironegocio objPN)
        {
            banco objBanco = new banco();

            parceironegocio objAlterar = objBanco.parceironegocio.Where(p => p.idParceiroNegocio == objPN.idParceiroNegocio).FirstOrDefault();

            objAlterar.Ativo = objPN.Ativo;

            objBanco.SaveChanges();
        }
        public List<parceironegocio> PesquisarCampoParceiro(string NomeRazao, int Ativo)
        {
            banco objBanco = new banco();

            List<parceironegocio> lstRetorno = objBanco.parceironegocio.Where(p => p.NomeRazao.Contains(NomeRazao) && p.Ativo == Ativo).ToList();

            return lstRetorno;
        }
        public List<parceironegocio> PesquisarParceiroUsuario()
        {
            banco objBanco = new banco();

            List<parceironegocio> lstRetorno = objBanco.parceironegocio.Where(p => p.Ativo == 1 && p.TipoPN == 0).ToList();

            return lstRetorno;
        }
        public List<parceironegocio> PesquisarParceiroCliente()
        {
            banco objBanco = new banco();

            List<parceironegocio> lstRetorno = objBanco.parceironegocio.Where(p => p.Ativo == 1 && p.TipoPN == 1).ToList();

            return lstRetorno;
        }
    }
}
