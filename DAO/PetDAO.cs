using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PetDAO
    {
        public List<PetVO> PesquisarPetCadastrado()
        {
            banco objBanco = new banco();
            List<PetVO> lstRetorno = new List<PetVO>();
            List<pet> lstConsulta = objBanco.pet.Include("tipopet").Include("parceironegocio").Include("porte").ToList();

            for (int i = 0; i < lstConsulta.Count(); i++)
            {
                PetVO objPETVO = new PetVO();

                objPETVO.Id = lstConsulta[i].idPet;
                objPETVO.Nome = lstConsulta[i].Nome;
                objPETVO.Idade = Convert.ToInt32(lstConsulta[i].Idade);
                objPETVO.Descricao = lstConsulta[i].Descricao;
                objPETVO.IdPN = lstConsulta[i].parceironegocio.idParceiroNegocio;
                objPETVO.NomeRazao = lstConsulta[i].parceironegocio.NomeRazao;
                objPETVO.IdTipo = lstConsulta[i].tipopet.idTipoPet;
                objPETVO.DescricaoTipo = lstConsulta[i].tipopet.Descricao;
                objPETVO.Sexo = lstConsulta[i].Sexo;
                objPETVO.Castrado = lstConsulta[i].Castrado;
                objPETVO.DtNascimento = Convert.ToDateTime(lstConsulta[i].dtNascimento);
                objPETVO.IdPorte = lstConsulta[i].porte.idPorte;
                objPETVO.DescricaoPorte = lstConsulta[i].porte.Descricao;
                objPETVO.Pelagem = lstConsulta[i].pelagem;
                objPETVO.Raca = lstConsulta[i].raca;

                lstRetorno.Add(objPETVO);
            }

            return lstRetorno;
        }
        public void CadastrarPet(pet objPet)
        {
            banco objBanco = new banco();
            objBanco.AddTopet(objPet);
            objBanco.SaveChanges();
        }
        public void AlterarPET(pet objPet)
        {
            banco objBanco = new banco();
            pet objAlterar = objBanco.pet.Where(p => p.idPet == objPet.idPet).FirstOrDefault();

            objAlterar.Nome = objPet.Nome;
            objAlterar.Idade = objPet.Idade;
            objAlterar.Descricao = objPet.Descricao;
            objAlterar.idPN = objPet.idPN;
            objAlterar.idTipo = objPet.idTipo;
            objAlterar.Sexo = objPet.Sexo;
            objAlterar.Castrado = objPet.Castrado;
            objAlterar.dtNascimento = objPet.dtNascimento;
            objAlterar.idPorte = objPet.idPorte;
            objAlterar.pelagem = objPet.pelagem;
            objAlterar.raca = objPet.raca;

            objBanco.SaveChanges();
        }
        public void ExcluirPet(int idPet)
        {
            banco objBanco = new banco();
            pet objDeletar = objBanco.pet.Where(p => p.idPet == idPet).FirstOrDefault();

            objBanco.DeleteObject(objDeletar);

            objBanco.SaveChanges();
        }
    }
}
