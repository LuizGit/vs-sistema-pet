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
    public partial class frmCadastroParceiroNegocio : Form
    {
        public frmCadastroParceiroNegocio()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ParceiroNegocioDAO objDao = new ParceiroNegocioDAO();
                parceironegocio objParceiro = new parceironegocio();

                objParceiro.NomeRazao = txtNome.Text.Trim();
                objParceiro.CpfCnpj = txtCpfCnpj.Text.Trim();
                objParceiro.TipoPN = Convert.ToInt32(cbmTipoParceiro.SelectedIndex);
                objParceiro.Contato = txtContato.Text.Trim();
                objParceiro.email = txtEmail.Text.Trim();
                objParceiro.Logradouro = txtLogradouro.Text.Trim();
                objParceiro.Bairro = txtBairro.Text.Trim();
                objParceiro.Cidade = txtCidade.Text.Trim();
                objParceiro.Estado = txtEstado.Text.Trim();
                objParceiro.Ativo = 1;

                try
                {
                    objDao.InserirParceiro(objParceiro);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarLista();

                }
                catch 
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }

                
            }

        }

        public bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";
            if (txtNome.Text.Trim() == "")
            {
                ret = false;
                campos = "- Nome\n";
            }
             if (txtCpfCnpj.Text.Trim() == "")
            {
                ret = false;
                campos += "- CPF ou CNPJ\n";
            }
             if (txtContato.Text.Trim() == "")
            {
                ret = false;
                campos += "- Numero para Contato\n";
            }
             if (cbmTipoParceiro.SelectedIndex == -1)
            {
                ret = false;
                campos += "- Informar o Tipo do Parceiro\n";
            }
            if (!ret)
            {
                Util.ExibirMsg(campos);
            }

            return ret;
        }
        public void LimparCampos()
        {
            Util.LimparCamposGenerico(gpbDados);
            Util.LimparCamposGenerico(bpbEndereco);
        }
        public void CarregarLista()
        {
            ParceiroNegocioDAO objDao = new ParceiroNegocioDAO();
            List<parceironegocio> lstParceiros = objDao.ConsultarParceiros();

            dgvPesquisaParceiro.DataSource = lstParceiros;

            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "idParceiroNegocio", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "TipoPN", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "Logradouro", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "Bairro", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "Cidade", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "Estado", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "Ativo", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "pet", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "usuario", false);


            Util.HeaderColunaGrid(dgvPesquisaParceiro,"NomeRazao", "Nome");
            Util.HeaderColunaGrid(dgvPesquisaParceiro, "CpfCnpj", "CPF / CNPJ");
            Util.HeaderColunaGrid(dgvPesquisaParceiro, "Contato", "Contato");
            Util.HeaderColunaGrid(dgvPesquisaParceiro, "email", "E-mail");
        }

        private void frmCadastroParceiroNegocio_Load(object sender, EventArgs e)
        {

            CarregarLista();
            LimparCampos();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Visible = false;
            
        }

        private void dgvPesquisaParceiro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPesquisaParceiro.RowCount > 0)
            {
                //ParceiroVO objLinhaClicada = (ParceiroVO)dgvPesquisaParceiro.CurrentRow.DataBoundItem;

                parceironegocio objParceiro = (parceironegocio)dgvPesquisaParceiro.CurrentRow.DataBoundItem;

                txtNome.Text = objParceiro.NomeRazao.ToString();
                txtCpfCnpj.Text = objParceiro.CpfCnpj.ToString();
                txtEmail.Text = objParceiro.email.ToString();
                txtContato.Text = objParceiro.Contato.ToString();
                cbmTipoParceiro.SelectedIndex = Convert.ToInt32(objParceiro.TipoPN);

                txtLogradouro.Text = objParceiro.Logradouro.ToString();
                txtBairro.Text = objParceiro.Bairro.ToString();
                txtCidade.Text = objParceiro.Cidade.ToString();
                txtEstado.Text = objParceiro.Estado.ToString();
                txtId.Text = objParceiro.idParceiroNegocio.ToString();

                btnCadastrar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Visible = true;

                dgvPesquisaParceiro.Enabled = false;

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ParceiroNegocioDAO objDao = new ParceiroNegocioDAO();
                parceironegocio objParceiro = new parceironegocio();

                objParceiro.NomeRazao = txtNome.Text.Trim();
                objParceiro.CpfCnpj = txtCpfCnpj.Text.Trim();
                objParceiro.TipoPN = Convert.ToInt32(cbmTipoParceiro.SelectedIndex);
                objParceiro.Contato = txtContato.Text.Trim();
                objParceiro.email = txtEmail.Text.Trim();
                objParceiro.Logradouro = txtLogradouro.Text.Trim();
                objParceiro.Bairro = txtBairro.Text.Trim();
                objParceiro.Cidade = txtCidade.Text.Trim();
                objParceiro.Estado = txtEstado.Text.Trim();
                objParceiro.idParceiroNegocio = Convert.ToInt32(txtId.Text.Trim());
                objParceiro.Ativo = 1;

                try
                {
                    objDao.AlterarParceiro(objParceiro);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarLista();
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCancelar.Visible = false;
                    dgvPesquisaParceiro.Enabled = true;

                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }


            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ParceiroNegocioDAO objDao = new ParceiroNegocioDAO();
            parceironegocio objParceiro = new parceironegocio();

            objParceiro.idParceiroNegocio = Convert.ToInt32(txtId.Text.Trim());
            objParceiro.Ativo = 0;

            try
            {
                objDao.InativarParceiro(objParceiro);
                Util.ExibirMsg(Util.TipoMsg.Sucesso);
                LimparCampos();
                CarregarLista();
                btnCadastrar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Visible = false;
                dgvPesquisaParceiro.Enabled = true;

            }
            catch
            {
                Util.ExibirMsg(Util.TipoMsg.Erro);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarLista();
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Visible = false;
            dgvPesquisaParceiro.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ParceiroNegocioDAO objDao = new ParceiroNegocioDAO();
            

            string NomeRazao = txtNomePesquisar.Text.ToString();
            int Ativo = cbmStatus.SelectedIndex;

            RecarregarPesquisaGrid(NomeRazao,Ativo);
        }
        public void RecarregarPesquisaGrid(string NomeRazao, int Ativo)
        {
            ParceiroNegocioDAO objDAO = new ParceiroNegocioDAO();
            List<parceironegocio> lstPesquisa = objDAO.PesquisarCampoParceiro(NomeRazao, Ativo);

            dgvPesquisaParceiro.DataSource = lstPesquisa;

            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "idParceiroNegocio", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "TipoPN", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "Logradouro", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "Bairro", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "Cidade", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "Estado", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "Ativo", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "pet", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaParceiro, "usuario", false);


            Util.HeaderColunaGrid(dgvPesquisaParceiro, "NomeRazao", "Nome");
            Util.HeaderColunaGrid(dgvPesquisaParceiro, "CpfCnpj", "CPF / CNPJ");
            Util.HeaderColunaGrid(dgvPesquisaParceiro, "Contato", "Contato");
            Util.HeaderColunaGrid(dgvPesquisaParceiro, "email", "E-mail");
        }
    }
}
