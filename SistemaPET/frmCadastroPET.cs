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

            Util.HeaderColunaGrid(dgvPesquisaPet, "Nome", "Nome");
            Util.HeaderColunaGrid(dgvPesquisaPet, "Sexo", "Sexo");
            Util.HeaderColunaGrid(dgvPesquisaPet, "NomeRazao", "Tutor");
            Util.HeaderColunaGrid(dgvPesquisaPet, "DescricaoTipo", "Espécie");
            Util.HeaderColunaGrid(dgvPesquisaPet, "DescricaoPorte", "Porte");
        }

    }
}
