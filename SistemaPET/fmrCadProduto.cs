using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace SistemaPET
{
    public partial class fmrCadProduto : Form
    {
        public fmrCadProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                mercadoria objMercadoria = new mercadoria();
                MercadoriaDAO objDAO = new MercadoriaDAO();

                objMercadoria.Descricao = txtDescricao.Text.Trim();
                objMercadoria.Preco = Convert.ToDecimal(txtPreco.Text.Trim());
                objMercadoria.CodBarras = txtCodBarras.Text.Trim();


                try
                {
                    objDAO.CadastrarMercadoria(objMercadoria);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarDgvProdutos();
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCancelar.Enabled = false;
                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);

                }



            }
        }

        private void LimparCampos()
        {
            Util.LimparCamposGenerico(gpbDados);


        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtDescricao.Text.Trim() == "")
            {
                ret = false;
                campos += " A descrição precisa ser preenchida! \n";
            }

            if (txtPreco.Text.Trim() == "")
            {
                ret = false;
                campos += "O preço precisa ser informado! \n";
            }

            if (!ret)
            {
                Util.ExibirMsg(campos);
            }

            return ret;

        }

        private void fmrCadProduto_Load(object sender, EventArgs e)
        {
            CarregarDgvProdutos();
        }

        private void CarregarDgvProdutos()
        {

            MercadoriaDAO objDAO = new MercadoriaDAO();
            List<mercadoria> lstmercadoria = objDAO.CarregarListaPesquisaMercadoria();

            dgvPesquisa.DataSource = lstmercadoria;



            Util.VisibilidadeColunaGrid(dgvPesquisa, "item_mercadoriaos", false);
            Util.VisibilidadeColunaGrid(dgvPesquisa, "item_pacote", false);
            Util.VisibilidadeColunaGrid(dgvPesquisa, "localestoque", false);


            Util.HeaderColunaGrid(dgvPesquisa, "Descricao", "Descrição");
            Util.HeaderColunaGrid(dgvPesquisa, "CodBarras", "Código de Barras");
            Util.HeaderColunaGrid(dgvPesquisa, "Preco", "Preço");
}

        






        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MercadoriaDAO objDao = new MercadoriaDAO();
                mercadoria objAlterar = new mercadoria();


                objAlterar.Descricao = txtDescricao.Text.Trim();
                objAlterar.Preco = Convert.ToDecimal(txtPreco.Text.Trim());
                objAlterar.CodBarras = txtCodBarras.Text.Trim();
                objAlterar.idMercadoria = Convert.ToInt32(txtId.Text.Trim());

                try
                {
                    objDao.AlterarMercadoria(objAlterar);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarDgvProdutos();
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCancelar.Enabled = false;
                    dgvPesquisa.Enabled = true;

                }
                catch (Exception)
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);

                    throw;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnCadastrar.Enabled = true;
            dgvPesquisa.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {

                Util.ExibirMsg(Util.TipoMsg.Erro);
            }
            else
            {
                MercadoriaDAO objDao = new MercadoriaDAO();
                try
                {
                    objDao.ExcluirMercadoria(Convert.ToInt32(txtId.Text.Trim()));
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarDgvProdutos();
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCancelar.Enabled = false;
                    dgvPesquisa.Enabled = true;
                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);



                }



            }

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPesquisa.RowCount > 0)
            {
                mercadoria objMerc = (mercadoria)dgvPesquisa.CurrentRow.DataBoundItem;

                txtCodBarras.Text = objMerc.CodBarras;
                txtDescricao.Text = objMerc.Descricao;
                txtPreco.Text =  objMerc.Preco.ToString();
                txtId.Text = objMerc.idMercadoria.ToString();
                CarregaCampoSaldo();
                btnCadastrar.Enabled = false;
                dgvPesquisa.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;

            }
        }
        private void CarregaCampoSaldo()
        {
            if (txtId.Text.Trim() == "")
            {
                Util.ExibirMsg("Não foi possivel carregar o Saldo pois não foi informado um id.");
            }
            else
            {
                EstoqueDAO objDao = new EstoqueDAO();

                txtSaldoEstoque.Text = Convert.ToString(objDao.CalculaSaldoMercadoria(Convert.ToInt32(txtId.Text.Trim())));
            }


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MercadoriaDAO objDao = new MercadoriaDAO();

            string Descricao = txtDescricaoPesquisa.Text;

            dgvPesquisa.DataSource = objDao.PesquisarCampoDescricao(Descricao);
        }
    
   

        private void dgvPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}