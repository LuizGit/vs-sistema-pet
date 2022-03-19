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

            cbmParceiroNegocio.DataSource = new ParceiroNegocioDAO().PesquisarParceiroUsuario();
        }
    }
}
