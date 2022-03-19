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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Usuario ou Senha não foram preenchidos corretamente");
            }
            else
            {
                UsuarioDAO objDao = new UsuarioDAO();
                string User = txtUsuario.Text.Trim();
                string Pass = txtSenha.Text.Trim();

                if(objDao.LoginEntity(User, Pass) == false)
                {
                    Util.ExibirMsg(Util.TipoMsg.DadosNaoEncontrado);
                }
                else
                {
                    fmrPrincipal f = new fmrPrincipal();
                    f.ShowDialog();
                    this.Close();
                }

            }
        }

        
    }
}
