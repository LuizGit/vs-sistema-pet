using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPET
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroParceiroNegocio f = new frmCadastroParceiroNegocio();
            f.ShowDialog();
        }

        private void fmrPrincipal_Shown(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Close();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrUsuario f = new fmrUsuario();
            f.ShowDialog();
        }

        private void pETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPET f = new frmCadastroPET();
            f.ShowDialog();
        }

        private void espécieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrEspecie f = new fmrEspecie();
            f.ShowDialog();
        }

        private void mercadoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrCadProduto f = new fmrCadProduto();
            f.ShowDialog();
        }
    }
}
