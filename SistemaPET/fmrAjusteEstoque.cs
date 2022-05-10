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
    public partial class fmrAjusteEstoque : Form
    {
        public fmrAjusteEstoque()
        {
            InitializeComponent();
        }

        private void fmrAjusteEstoque_Load(object sender, EventArgs e)
        {
            CarregarDGVPesquisaLoad();
            CarregarDGVHistórico();
            btnCancelar.Enabled = false;
        }
        private void CarregarDGVPesquisaLoad()
        {
            MercadoriaDAO objDao = new MercadoriaDAO();
            List<mercadoria> lstMercadoria = objDao.CarregarListaPesquisaMercadoria();

            dgvMercadoriaPesquisa.DataSource = lstMercadoria;

            Util.VisibilidadeColunaGrid(dgvMercadoriaPesquisa, "item_mercadoriaos", false);
            Util.VisibilidadeColunaGrid(dgvMercadoriaPesquisa, "item_pacote", false);
            Util.VisibilidadeColunaGrid(dgvMercadoriaPesquisa, "localestoque", false);


            Util.HeaderColunaGrid(dgvMercadoriaPesquisa, "idMercadoria", "Identificador");
            Util.HeaderColunaGrid(dgvMercadoriaPesquisa, "Descricao", "Descrição");
            Util.HeaderColunaGrid(dgvMercadoriaPesquisa, "CodBarras", "Cod. de Barras");
            Util.HeaderColunaGrid(dgvMercadoriaPesquisa, "Preco", "Preço");
        }
        private void CarregarDGVHistórico()
        {
            string idMerc = txtIdMercadoria.Text;
            EstoqueDAO objDao = new EstoqueDAO();
            List<MovimentoEstoqueVO> lstHistorico = objDao.CarregarHistórico(idMerc);

            dgvHistorico.DataSource = lstHistorico;

            Util.HeaderColunaGrid(dgvHistorico, "idMovimento", "Cod. Movimentação");
            Util.HeaderColunaGrid(dgvHistorico, "Quantidade", "Quantidade");
            Util.HeaderColunaGrid(dgvHistorico, "idMercadoria", "Cod. Mercadoria");
            Util.HeaderColunaGrid(dgvHistorico, "EntradaSaida", "Entrada / Saida");
            Util.HeaderColunaGrid(dgvHistorico, "Descricao", "Descrição ");
            Util.HeaderColunaGrid(dgvHistorico, "CodBarras", "Cod. de Barras");
            Util.HeaderColunaGrid(dgvHistorico, "Preco", "Preço");
        }

        private void dgvMercadoriaPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMercadoriaPesquisa.RowCount > 0)
            {
                mercadoria objLinhaSelecionada = (mercadoria)dgvMercadoriaPesquisa.CurrentRow.DataBoundItem;

                txtIdMercadoria.Text = objLinhaSelecionada.idMercadoria.ToString();
                lblCodBarras.Text = String.IsNullOrWhiteSpace(objLinhaSelecionada.CodBarras) ? "..." : objLinhaSelecionada.CodBarras;
                lblDescricao.Text = objLinhaSelecionada.Descricao;
                CarregarCampoSaldo(objLinhaSelecionada.idMercadoria);

                btnCancelar.Enabled = true;
                dgvMercadoriaPesquisa.Enabled = false;
            }
        }
        

        private void LimparCampos()
        {
            lblCodBarras.Text = "...";
            lblDescricao.Text = "...";
            txtIdMercadoria.Clear();
            txtQtd.Clear();
            dgvMercadoriaPesquisa.Enabled = true;
            cbmTipo.SelectedIndex = -1;
            txtSaldo.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                EstoqueDAO objDao = new EstoqueDAO();
                localestoque objMovimentoEstoque = new localestoque();

                objMovimentoEstoque.EntradaSaida = Convert.ToInt32(cbmTipo.SelectedIndex);
                objMovimentoEstoque.Mercadoria_idMercadoria = Convert.ToInt32(txtIdMercadoria.Text);
                objMovimentoEstoque.Quantidade = Convert.ToInt32(txtQtd.Text);

                try
                {
                    objDao.LancarMovimentoEstoque(objMovimentoEstoque);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    btnCancelar.Enabled = false;
                    dgvMercadoriaPesquisa.Enabled = true;
                    LimparCampos();
                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }
            }
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (String.IsNullOrWhiteSpace(txtIdMercadoria.Text))
            {
                ret = false;
                campos = " - Selecione uma mercadoria para poder realizar uma operação!\n";
            }
            if (String.IsNullOrWhiteSpace(txtQtd.Text))
            {
                ret = false;
                campos += " - o campo Quantidade esta vazia!\n";
            }
            if (cbmTipo.SelectedIndex == -1)
            {
                ret = false;
                campos += " - Selecione o 'Tipo' da movimentação\n";
            }
            if (!ret)
            {
                Util.ExibirMsg(campos);
            }
            return ret;
        }

        private void txtIdMercadoria_TextChanged(object sender, EventArgs e)
        {
            CarregarDGVHistórico();
        }

        private void CarregarCampoSaldo( int idMerc)
        {
            EstoqueDAO objDao = new EstoqueDAO();

            txtSaldo.Text = objDao.CalculaSaldoMercadoria(idMerc).ToString();
        }

        private void txtDescPesquisa_TextChanged(object sender, EventArgs e)
        {
            MercadoriaDAO objDao = new MercadoriaDAO();
            List<mercadoria> lstMercadoria = objDao.PesquisaMercadoriaPorDescricao(txtDescPesquisa.Text);

            dgvMercadoriaPesquisa.DataSource = lstMercadoria;

            Util.VisibilidadeColunaGrid(dgvMercadoriaPesquisa, "item_mercadoriaos", false);
            Util.VisibilidadeColunaGrid(dgvMercadoriaPesquisa, "item_pacote", false);
            Util.VisibilidadeColunaGrid(dgvMercadoriaPesquisa, "localestoque", false);


            Util.HeaderColunaGrid(dgvMercadoriaPesquisa, "idMercadoria", "Identificador");
            Util.HeaderColunaGrid(dgvMercadoriaPesquisa, "Descricao", "Descrição");
            Util.HeaderColunaGrid(dgvMercadoriaPesquisa, "CodBarras", "Cod. de Barras");
            Util.HeaderColunaGrid(dgvMercadoriaPesquisa, "Preco", "Preço");
        }
    }
}
