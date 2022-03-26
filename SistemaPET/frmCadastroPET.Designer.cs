
namespace SistemaPET
{
    partial class frmCadastroPET
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.nudIdade = new System.Windows.Forms.NumericUpDown();
            this.lblAnos = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.cbmTutor = new System.Windows.Forms.ComboBox();
            this.lblTutor = new System.Windows.Forms.Label();
            this.cbmPorte = new System.Windows.Forms.ComboBox();
            this.lblPorte = new System.Windows.Forms.Label();
            this.cbmEspecie = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.txtPelagem = new System.Windows.Forms.TextBox();
            this.lblPelagem = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.cbmCastrado = new System.Windows.Forms.ComboBox();
            this.lblCastrado = new System.Windows.Forms.Label();
            this.cbmSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.dtpAniversario = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.dgvPesquisaPet = new System.Windows.Forms.DataGridView();
            this.gpbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaPet)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txtId);
            this.gpbDados.Controls.Add(this.nudIdade);
            this.gpbDados.Controls.Add(this.lblAnos);
            this.gpbDados.Controls.Add(this.lblIdade);
            this.gpbDados.Controls.Add(this.btnCancelar);
            this.gpbDados.Controls.Add(this.btnExcluir);
            this.gpbDados.Controls.Add(this.btnAlterar);
            this.gpbDados.Controls.Add(this.btnCadastrar);
            this.gpbDados.Controls.Add(this.txtObs);
            this.gpbDados.Controls.Add(this.lblObs);
            this.gpbDados.Controls.Add(this.cbmTutor);
            this.gpbDados.Controls.Add(this.lblTutor);
            this.gpbDados.Controls.Add(this.cbmPorte);
            this.gpbDados.Controls.Add(this.lblPorte);
            this.gpbDados.Controls.Add(this.cbmEspecie);
            this.gpbDados.Controls.Add(this.lblEspecie);
            this.gpbDados.Controls.Add(this.txtPelagem);
            this.gpbDados.Controls.Add(this.lblPelagem);
            this.gpbDados.Controls.Add(this.txtRaca);
            this.gpbDados.Controls.Add(this.lblRaca);
            this.gpbDados.Controls.Add(this.cbmCastrado);
            this.gpbDados.Controls.Add(this.lblCastrado);
            this.gpbDados.Controls.Add(this.cbmSexo);
            this.gpbDados.Controls.Add(this.lblSexo);
            this.gpbDados.Controls.Add(this.dtpAniversario);
            this.gpbDados.Controls.Add(this.label2);
            this.gpbDados.Controls.Add(this.txtNome);
            this.gpbDados.Controls.Add(this.lblNome);
            this.gpbDados.Location = new System.Drawing.Point(7, 7);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(428, 488);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados Cadastrais";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(18, 446);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(32, 20);
            this.txtId.TabIndex = 48;
            this.txtId.Visible = false;
            // 
            // nudIdade
            // 
            this.nudIdade.Location = new System.Drawing.Point(237, 225);
            this.nudIdade.Name = "nudIdade";
            this.nudIdade.Size = new System.Drawing.Size(35, 20);
            this.nudIdade.TabIndex = 47;
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Location = new System.Drawing.Point(271, 227);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(33, 13);
            this.lblAnos.TabIndex = 46;
            this.lblAnos.Text = "anos.";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(200, 227);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 44;
            this.lblIdade.Text = "Idade:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(232, 448);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(119, 408);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 42;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(213, 408);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 41;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(304, 408);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 40;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(68, 304);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(273, 98);
            this.txtObs.TabIndex = 39;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(15, 307);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(32, 13);
            this.lblObs.TabIndex = 38;
            this.lblObs.Text = "Obs.:";
            // 
            // cbmTutor
            // 
            this.cbmTutor.FormattingEnabled = true;
            this.cbmTutor.Location = new System.Drawing.Point(68, 264);
            this.cbmTutor.Name = "cbmTutor";
            this.cbmTutor.Size = new System.Drawing.Size(239, 21);
            this.cbmTutor.TabIndex = 37;
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(15, 267);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(35, 13);
            this.lblTutor.TabIndex = 36;
            this.lblTutor.Text = "Tutor:";
            // 
            // cbmPorte
            // 
            this.cbmPorte.FormattingEnabled = true;
            this.cbmPorte.Location = new System.Drawing.Point(68, 224);
            this.cbmPorte.Name = "cbmPorte";
            this.cbmPorte.Size = new System.Drawing.Size(126, 21);
            this.cbmPorte.TabIndex = 35;
            // 
            // lblPorte
            // 
            this.lblPorte.AutoSize = true;
            this.lblPorte.Location = new System.Drawing.Point(14, 227);
            this.lblPorte.Name = "lblPorte";
            this.lblPorte.Size = new System.Drawing.Size(35, 13);
            this.lblPorte.TabIndex = 34;
            this.lblPorte.Text = "Porte:";
            // 
            // cbmEspecie
            // 
            this.cbmEspecie.FormattingEnabled = true;
            this.cbmEspecie.Location = new System.Drawing.Point(259, 182);
            this.cbmEspecie.Name = "cbmEspecie";
            this.cbmEspecie.Size = new System.Drawing.Size(82, 21);
            this.cbmEspecie.TabIndex = 33;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(210, 185);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(48, 13);
            this.lblEspecie.TabIndex = 32;
            this.lblEspecie.Text = "Espécie:";
            // 
            // txtPelagem
            // 
            this.txtPelagem.Location = new System.Drawing.Point(68, 182);
            this.txtPelagem.Name = "txtPelagem";
            this.txtPelagem.Size = new System.Drawing.Size(126, 20);
            this.txtPelagem.TabIndex = 31;
            // 
            // lblPelagem
            // 
            this.lblPelagem.AutoSize = true;
            this.lblPelagem.Location = new System.Drawing.Point(15, 185);
            this.lblPelagem.Name = "lblPelagem";
            this.lblPelagem.Size = new System.Drawing.Size(51, 13);
            this.lblPelagem.TabIndex = 30;
            this.lblPelagem.Text = "Pelagem:";
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(68, 141);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(273, 20);
            this.txtRaca.TabIndex = 29;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(15, 144);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(36, 13);
            this.lblRaca.TabIndex = 28;
            this.lblRaca.Text = "Raça:";
            // 
            // cbmCastrado
            // 
            this.cbmCastrado.FormattingEnabled = true;
            this.cbmCastrado.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbmCastrado.Location = new System.Drawing.Point(268, 102);
            this.cbmCastrado.Name = "cbmCastrado";
            this.cbmCastrado.Size = new System.Drawing.Size(73, 21);
            this.cbmCastrado.TabIndex = 27;
            // 
            // lblCastrado
            // 
            this.lblCastrado.AutoSize = true;
            this.lblCastrado.Location = new System.Drawing.Point(210, 105);
            this.lblCastrado.Name = "lblCastrado";
            this.lblCastrado.Size = new System.Drawing.Size(52, 13);
            this.lblCastrado.TabIndex = 26;
            this.lblCastrado.Text = "Castrado:";
            // 
            // cbmSexo
            // 
            this.cbmSexo.FormattingEnabled = true;
            this.cbmSexo.Items.AddRange(new object[] {
            "Femea",
            "Macho"});
            this.cbmSexo.Location = new System.Drawing.Point(68, 102);
            this.cbmSexo.Name = "cbmSexo";
            this.cbmSexo.Size = new System.Drawing.Size(126, 21);
            this.cbmSexo.TabIndex = 25;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(15, 105);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 24;
            this.lblSexo.Text = "Sexo:";
            // 
            // dtpAniversario
            // 
            this.dtpAniversario.Location = new System.Drawing.Point(94, 63);
            this.dtpAniversario.Name = "dtpAniversario";
            this.dtpAniversario.Size = new System.Drawing.Size(213, 20);
            this.dtpAniversario.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Dt. Aniversario:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(273, 20);
            this.txtNome.TabIndex = 21;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome:";
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.dgvPesquisaPet);
            this.gpbPesquisa.Location = new System.Drawing.Point(445, 7);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(502, 487);
            this.gpbPesquisa.TabIndex = 1;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Cadastrados";
            // 
            // dgvPesquisaPet
            // 
            this.dgvPesquisaPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaPet.Location = new System.Drawing.Point(9, 116);
            this.dgvPesquisaPet.MultiSelect = false;
            this.dgvPesquisaPet.Name = "dgvPesquisaPet";
            this.dgvPesquisaPet.ReadOnly = true;
            this.dgvPesquisaPet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisaPet.Size = new System.Drawing.Size(492, 364);
            this.dgvPesquisaPet.TabIndex = 0;
            this.dgvPesquisaPet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisaPet_CellClick);
            // 
            // frmCadastroPET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 506);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.gpbDados);
            this.Name = "frmCadastroPET";
            this.Text = "Cadastro de PET";
            this.Load += new System.EventHandler(this.frmCadastroPET_Load);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaPet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.ComboBox cbmTutor;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.ComboBox cbmPorte;
        private System.Windows.Forms.Label lblPorte;
        private System.Windows.Forms.ComboBox cbmEspecie;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.TextBox txtPelagem;
        private System.Windows.Forms.Label lblPelagem;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.ComboBox cbmCastrado;
        private System.Windows.Forms.Label lblCastrado;
        private System.Windows.Forms.ComboBox cbmSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.DateTimePicker dtpAniversario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.DataGridView dgvPesquisaPet;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblAnos;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.NumericUpDown nudIdade;
        private System.Windows.Forms.TextBox txtId;
    }
}