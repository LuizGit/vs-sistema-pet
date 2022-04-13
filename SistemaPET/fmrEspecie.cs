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
    public partial class fmrEspecie : Form
    {
        public fmrEspecie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tipopet objTipo = new tipopet();

                TipoPetDAO objDao = new TipoPetDAO();

                objTipo.Descricao = txtDescricao.Text.Trim();

                try
                {
                    objDao.CadastrarEspecie(objTipo);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    CarregarDgvPesquisaTipoPet();
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

            if (txtDescricao.Text.Trim() == "")
            {
                ret = false;
                campos += " - A descrição precisa ser preenchida. \n";
            }
            if (!ret)
            {
                Util.ExibirMsg(campos);
            }

            return ret;
        }
        private void LimparCampos() {

            Util.LimparCamposGenerico(gpbDados); 
        
        
        }

        private void CarregarDgvPesquisaTipoPet()
        {
            TipoPetDAO objpetDAO = new TipoPetDAO();
            List<tipopet> lsttipopet = objpetDAO.PesquisarTipoPet();

            dgvPesquisa.DataSource = lsttipopet;

            Util.VisibilidadeColunaGrid(dgvPesquisa, "idTipoPet", false);
            Util.VisibilidadeColunaGrid(dgvPesquisa, "Pet", false);

            Util.HeaderColunaGrid(dgvPesquisa,"Descricao", "Descrição");
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void fmrEspecie_Load(object sender, EventArgs e)
        {
            CarregarDgvPesquisaTipoPet();
        }

        private void dgvPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPesquisa.RowCount > 0)
            {
                tipopet objTipoPet = (tipopet)dgvPesquisa.CurrentRow.DataBoundItem;

                txtIdTipoPet.Text = objTipoPet.idTipoPet.ToString();
                txtDescricao.Text = objTipoPet.Descricao;

            }
        }
    }
}
