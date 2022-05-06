using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EstoqueDAO
    {
        public void LancarMovimentoEstoque(localestoque objMovimentoEstoque)
        {
            banco objBanco = new banco();

            objBanco.AddTolocalestoque(objMovimentoEstoque);

            objBanco.SaveChanges();
        }
        public List<MovimentoEstoqueVO> CarregarHistórico(String idMerc)
        {
            banco objBanco = new banco();
            List<MovimentoEstoqueVO> lstMovimento = new List<MovimentoEstoqueVO>();
            if (!String.IsNullOrWhiteSpace(idMerc))
            {
                int idMercadoria = Convert.ToInt32(idMerc);
                List<localestoque> lstConsulta = objBanco.localestoque.Include("mercadoria").Where(e => e.Mercadoria_idMercadoria == idMercadoria).ToList();
                for (int i = 0; i < lstConsulta.Count(); i++)
                {
                    MovimentoEstoqueVO objMov = new MovimentoEstoqueVO();

                    objMov.idMovimento = lstConsulta[i].idLocalEstoque;
                    objMov.idMercadoria = lstConsulta[i].mercadoria.idMercadoria;
                    objMov.EntradaSaida = lstConsulta[i].EntradaSaida == 0 ? "Entrada" : "Saida";
                    objMov.Quantidade = lstConsulta[i].Quantidade;
                    objMov.CodBarras = lstConsulta[i].mercadoria.CodBarras;
                    objMov.Descricao = lstConsulta[i].mercadoria.Descricao;
                    objMov.Preco = lstConsulta[i].mercadoria.Preco;

                    lstMovimento.Add(objMov);
                }
            }
            else
            {
                List<localestoque> lstConsulta = objBanco.localestoque.Include("mercadoria").ToList();
                for (int i = 0; i < lstConsulta.Count(); i++)
                {
                    MovimentoEstoqueVO objMov = new MovimentoEstoqueVO();

                    objMov.idMovimento = lstConsulta[i].idLocalEstoque;
                    objMov.idMercadoria = lstConsulta[i].mercadoria.idMercadoria;
                    objMov.EntradaSaida = lstConsulta[i].EntradaSaida == 0 ? "Entrada" : "Saida";
                    objMov.Quantidade = lstConsulta[i].Quantidade;
                    objMov.CodBarras = lstConsulta[i].mercadoria.CodBarras;
                    objMov.Descricao = lstConsulta[i].mercadoria.Descricao;
                    objMov.Preco = lstConsulta[i].mercadoria.Preco;

                    lstMovimento.Add(objMov);
                }
            }

            

            return lstMovimento;
        }

        public decimal CalculaSaldoMercadoria(int idMerc)
        {
            
            decimal qtdEntrada = 0;
            decimal qtdSaida = 0;
            decimal Saldo = 0;
            banco objBanco = new banco();
            List<localestoque> lstEntrada = objBanco.localestoque.Where(e => e.EntradaSaida == 0 && e.Mercadoria_idMercadoria == idMerc).ToList();
            List<localestoque> lstSaida = objBanco.localestoque.Where(e => e.EntradaSaida == 1 && e.Mercadoria_idMercadoria == idMerc).ToList();
            if (lstEntrada.Count() > 0)
            {
                for (int i = 0; i < lstEntrada.Count(); i++)
                {
                    qtdEntrada += lstEntrada[i].Quantidade;
                }
            }
            if (lstSaida.Count() > 0)
            {
                for (int i = 0; i < lstSaida.Count(); i++)
                {
                    qtdSaida += lstSaida[i].Quantidade;
                }
            }
            Saldo = qtdEntrada - qtdSaida;

            return Saldo;
        }
    }
}
