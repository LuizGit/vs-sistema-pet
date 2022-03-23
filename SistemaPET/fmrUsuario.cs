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
    public partial class fmrUsuario : Form
    {
        public fmrUsuario()
        {
            InitializeComponent();
        }

        private void fmrUsuario_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            CarregarDGVUsuarios();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Visible = false;
            cbmParceiroNegocio.SelectedIndex = -1;
            
        }
        private void CarregarCombos()
        {
            cbmParceiroNegocio.DisplayMember = "NomeRazao";
            cbmParceiroNegocio.ValueMember = "idParceiroNegocio";
            cbmParceiroNegocio.DataSource = new ParceiroNegocioDAO().PesquisarParceiroUsuario();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                usuario objUsuario = new usuario();
                UsuarioDAO objDao = new UsuarioDAO();

                objUsuario.Login = txtUsuario.Text.Trim();
                objUsuario.Senha = txtSenha.Text.Trim();
                objUsuario.idPN = Convert.ToInt32(cbmParceiroNegocio.SelectedValue);

                try
                {
                    objDao.CadastrarUsuario(objUsuario);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarDGVUsuarios();
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
            if (txtUsuario.Text.Trim() == "")
            {
                ret = false;
                campos += " - Usuario\n";
            }
            if (txtSenha.Text.Trim() == "")
            {
                ret = false;
                campos += " - Senha\n";
            }
            if (cbmParceiroNegocio.SelectedIndex == -1)
            {
                ret = false;
                campos += " - Parceiro de Negocio\n";
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
            
        }
        public void CarregarDGVUsuarios()
        {
            UsuarioDAO objDao = new UsuarioDAO();
            List<UsuarioPNVO> lstConsulta = objDao.CarrgarUsuariosCadastrados();

            dgvUsuarios.DataSource = lstConsulta;

            Util.VisibilidadeColunaGrid(dgvUsuarios, "IdPN", false);
            Util.VisibilidadeColunaGrid(dgvUsuarios, "Senha", false);


            Util.HeaderColunaGrid(dgvUsuarios, "Id", "Identificador");
            Util.HeaderColunaGrid(dgvUsuarios, "Login", "Login");
            Util.HeaderColunaGrid(dgvUsuarios, "NomeRazaoPN", "Nome do Usuario");

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.RowCount > 0)
            {
                UsuarioPNVO objUPN = (UsuarioPNVO)dgvUsuarios.CurrentRow.DataBoundItem;

                //usuario objUPN = (usuario)dgvUsuarios.CurrentRow.DataBoundItem;

                txtId.Text = objUPN.Id.ToString();
                txtUsuario.Text = objUPN.Login;
                txtSenha.Text = objUPN.Senha;
                cbmParceiroNegocio.SelectedValue = objUPN.IdPN;

                btnCadastrar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Visible = true;

                dgvUsuarios.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Visible = false;

            dgvUsuarios.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                UsuarioDAO objDAO = new UsuarioDAO();
                usuario objUsuario = new usuario();

                objUsuario.idUsuario = Convert.ToInt32(txtId.Text.Trim());
                objUsuario.Login = txtUsuario.Text.Trim();
                objUsuario.Senha = txtSenha.Text.Trim();
                objUsuario.idPN = Convert.ToInt32(cbmParceiroNegocio.SelectedValue);

                try
                {
                    objDAO.AletarUsuario(objUsuario);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarDGVUsuarios();
                    CarregarCombos();
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCancelar.Visible = false;

                    dgvUsuarios.Enabled = true;

                }
                catch 
                {

                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() != "")
            {
                UsuarioDAO objDao = new UsuarioDAO();

                int id = Convert.ToInt32(txtId.Text);

                try
                {
                    objDao.ExcluirUsuario(id);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarDGVUsuarios();
                    CarregarCombos();
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCancelar.Visible = false;

                    dgvUsuarios.Enabled = true;
                }
                catch 
                {

                    Util.ExibirMsg(Util.TipoMsg.ErroExclusao);
                }
            }
        }
    }
}
