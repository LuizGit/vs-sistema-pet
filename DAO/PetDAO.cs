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

                lstRetorno.Add(objPETVO);
            }

            return lstRetorno;
        }
    }
}
