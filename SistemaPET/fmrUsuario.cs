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
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            CarregarCombos();
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
    }
}
