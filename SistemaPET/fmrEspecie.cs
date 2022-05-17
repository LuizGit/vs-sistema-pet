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
                //Aqui ele instanciou o que seia a tabela
                tipopet objTipo = new tipopet();

                //Aqui ele intanciou a DAO
                TipoPetDAO objDao = new TipoPetDAO();

                objTipo.Descricao = txtDescricao.Text.Trim();

                try
                {
                    objDao.CadastrarEspecie(objTipo);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    CarregarDgvPesquisaTipoPet();
                    LimparCampos();
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    BtnCancelar.Enabled = false;

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
            if (txtIdTipoPet.Text.Trim()== "")
            {

                Util.ExibirMsg(Util.TipoMsg.Erro);
            }
            else
            {
                TipoPetDAO objDao = new TipoPetDAO();
                try
                {
                    objDao.ExcluirTipoPet(Convert.ToInt32(txtIdTipoPet.Text.Trim()));
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarDgvPesquisaTipoPet();
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    BtnCancelar.Enabled = false;
               }
                catch 
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);


                   
                }


            }
        

        }

        private void fmrEspecie_Load(object sender, EventArgs e)
        {
            CarregarDgvPesquisaTipoPet();
        }

        private void dgvPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento referente a seleção de uma linha na DGV
            if (dgvPesquisa.RowCount > 0)
            {

                tipopet objTipoPet = (tipopet)dgvPesquisa.CurrentRow.DataBoundItem;

                //Pega da Grid e joga para os txt's
                txtIdTipoPet.Text = objTipoPet.idTipoPet.ToString();
                txtDescricao.Text = objTipoPet.Descricao;
                btnCadastrar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                BtnCancelar.Enabled = true;

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                TipoPetDAO objDao = new TipoPetDAO();
                tipopet objAlterar = new tipopet();


                objAlterar.Descricao = txtDescricao.Text.Trim();
                objAlterar.idTipoPet = Convert.ToInt32(txtIdTipoPet.Text.Trim());

                try
                {
                    objDao.AlterarEspecie(objAlterar);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarDgvPesquisaTipoPet();
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    BtnCancelar.Enabled = false;

                }
                catch (Exception)
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);

                    throw;
                }



            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            BtnCancelar.Enabled = false;
            btnCadastrar.Enabled = true;
        }

        private void dgvPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gpbPesquisa_Enter(object sender, EventArgs e)
        {

        }
    }
}
