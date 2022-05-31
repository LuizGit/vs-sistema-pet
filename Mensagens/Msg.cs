using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagens
{
    public static class Msg
    {
        /// <summary>
        /// Ação realizada com sucesso
        /// </summary>
        public static string MensagemSucesso = "Ação realizada com sucesso";
        /// <summary>
        /// Ocorreu um erro na operação
        /// </summary>
        public static string MensagemErro = "Ocorreu um erro na operação";
        /// <summary>
        /// Não foi encontrado nenhum registro
        /// </summary>
        public static string MensagemRegistroNaoEncontrado = "Não foi possivel realizar a operação";
        /// <summary>
        /// Favor preencher o(s) campos(s) obrigatório(s)
        /// </summary>
        public static string MensagemCampoObg = "Favor preencher o(s) campos(s) obrigatório(s)";


        public static string MensagemPerguntaExcluir = "Deseja realmente do fundo do seu coração excluir este registro?";
        public static string MensagemErroExclusao = "Eu sei que você quer excluir, mas não deu certo, tenta novamente depois de tirar seu nome do SERASA.";



        public static string TituloSucesso = "Sucesso";
        public static string TituloErro = "Erro";
        public static string TituloAviso = "Aviso";
    }
}
