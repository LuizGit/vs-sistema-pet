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
    public partial class frmCadastroPET : Form
    {
        public frmCadastroPET()
        {
            InitializeComponent();
        }

        private void frmCadastroPET_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            CarregarDgvPesquisarPet();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Visible = false;

            cbmCastrado.SelectedIndex = -1;
            cbmEspecie.SelectedIndex = -1;
            cbmPorte.SelectedIndex = -1;
            cbmSexo.SelectedIndex = -1;
            cbmTutor.SelectedIndex = -1;
        }
        public void CarregarCombos()
        {
            cbmTutor.DisplayMember = "NomeRazao";
            cbmTutor.ValueMember = "idParceiroNegocio";
            cbmTutor.DataSource = new ParceiroNegocioDAO().PesquisarParceiroCliente();

            cbmEspecie.DisplayMember = "Descricao";
            cbmEspecie.ValueMember = "idTipoPet";
            cbmEspecie.DataSource = new TipoPetDAO().PesquisarTipoPet();

            cbmPorte.DisplayMember = "Descricao";
            cbmPorte.ValueMember = "idPorte";
            cbmPorte.DataSource = new PorteDAO().PesquisarPorte();
        }
        public void CarregarDgvPesquisarPet()
        {
            PetDAO objDao = new PetDAO();
            List<PetVO> lstPesquisa = objDao.PesquisarPetCadastrado();

            dgvPesquisaPet.DataSource = lstPesquisa;

            Util.VisibilidadeColunaGrid(dgvPesquisaPet, "Id", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaPet, "Descricao", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaPet, "Idade", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaPet, "IdTipo", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaPet, "IdPN", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaPet, "IdPorte", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaPet, "DtNascimento", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaPet, "Castrado", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaPet, "Pelagem", false);
            Util.VisibilidadeColunaGrid(dgvPesquisaPet, "Raca", false);

            Util.HeaderColunaGrid(dgvPesquisaPet, "Nome", "Nome");
            Util.HeaderColunaGrid(dgvPesquisaPet, "Sexo", "Sexo");
            Util.HeaderColunaGrid(dgvPesquisaPet, "NomeRazao", "Tutor");
            Util.HeaderColunaGrid(dgvPesquisaPet, "DescricaoTipo", "Espécie");
            Util.HeaderColunaGrid(dgvPesquisaPet, "DescricaoPorte", "Porte");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                PetDAO objDao = new PetDAO();
                pet objPet = new pet();

                int Idade = Convert.ToInt32(nudIdade.Value);

                objPet.Nome = txtNome.Text.Trim();
                objPet.Idade = Idade;
                objPet.Descricao = txtObs.Text.Trim();
                objPet.idTipo = Convert.ToInt32(cbmEspecie.SelectedValue);
                objPet.idPN = Convert.ToInt32(cbmTutor.SelectedValue); ;
                objPet.Sexo = cbmSexo.SelectedItem.ToString();
                objPet.Castrado = cbmCastrado.SelectedIndex;
                objPet.dtNascimento = dtpAniversario.Value;
                objPet.idPorte = Convert.ToInt32(cbmPorte.SelectedValue);
                objPet.pelagem = txtPelagem.Text.Trim();

                try
                {
                    objDao.CadastrarPet(objPet);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarDgvPesquisarPet();
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCancelar.Visible = false;

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
                campos += " - Nome do Pet\n";
            }
            if (cbmSexo.SelectedIndex == -1)
            {
                ret = false;
                campos += " - Sexo do Pet\n";
            }
            if (cbmCastrado.SelectedIndex == -1)
            {
                ret = false;
                campos += " - Castrado, sim ou não?\n";
            }
            if (txtRaca.Text.Trim() == "")
            {
                ret = false;
                campos += " - Raça do Pet\n";
            }
            if (cbmEspecie.SelectedIndex == -1)
            {
                ret = false;
                campos += " - Especie do Pet\n";
            }
            if (cbmPorte.SelectedIndex == -1)
            {
                ret = false;
                campos += " - Porte do Pet\n";
            }
            if (cbmTutor.SelectedIndex == -1)
            {
                ret = false;
                campos += " - Tutor do Pet\n";
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
            nudIdade.Value = 0;
            dtpAniversario.Value = DateTime.Now;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void dgvPesquisaPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPesquisaPet.RowCount > 0)
            {
                PetVO objPet = (PetVO)dgvPesquisaPet.CurrentRow.DataBoundItem;

                txtId.Text = objPet.Id.ToString();
                txtNome.Text = objPet.Nome;
                txtObs.Text = objPet.Descricao;
                txtPelagem.Text = objPet.Pelagem;
                txtRaca.Text = objPet.Raca;
                cbmCastrado.SelectedIndex = objPet.Castrado;
                cbmEspecie.SelectedValue = objPet.IdTipo;
                cbmPorte.SelectedValue = objPet.IdPorte;
                cbmSexo.SelectedItem = objPet.Sexo;
                cbmTutor.SelectedValue = objPet.IdPN;

                btnCadastrar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Visible = true;

                dgvPesquisaPet.Enabled = false;
            }
        }
    }
}
