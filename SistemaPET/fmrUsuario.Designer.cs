
namespace SistemaPET
{
    partial class fmrUsuario
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbmParceiroNegocio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gpbDados.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.btnCancelar);
            this.gpbDados.Controls.Add(this.txtId);
            this.gpbDados.Controls.Add(this.cbmParceiroNegocio);
            this.gpbDados.Controls.Add(this.label1);
            this.gpbDados.Controls.Add(this.btnExcluir);
            this.gpbDados.Controls.Add(this.btnAlterar);
            this.gpbDados.Controls.Add(this.btnCadastrar);
            this.gpbDados.Controls.Add(this.txtSenha);
            this.gpbDados.Controls.Add(this.lblSenha);
            this.gpbDados.Controls.Add(this.txtUsuario);
            this.gpbDados.Controls.Add(this.lblUsuario);
            this.gpbDados.Location = new System.Drawing.Point(8, 7);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(440, 193);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(266, 154);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(383, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(49, 20);
            this.txtId.TabIndex = 16;
            this.txtId.Visible = false;
            // 
            // cbmParceiroNegocio
            // 
            this.cbmParceiroNegocio.FormattingEnabled = true;
            this.cbmParceiroNegocio.Location = new System.Drawing.Point(126, 80);
            this.cbmParceiroNegocio.Name = "cbmParceiroNegocio";
            this.cbmParceiroNegocio.Size = new System.Drawing.Size(263, 21);
            this.cbmParceiroNegocio.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Parceiro:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(101, 116);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(214, 116);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(326, 116);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(126, 51);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(167, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(53, 54);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(126, 25);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(167, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(53, 28);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario:";
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.dgvUsuarios);
            this.gpbPesquisa.Location = new System.Drawing.Point(8, 206);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(439, 284);
            this.gpbPesquisa.TabIndex = 1;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 67);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(429, 211);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // fmrUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 502);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.gpbDados);
            this.Name = "fmrUsuario";
            this.Text = "Cadastro de Usuario";
            this.Load += new System.EventHandler(this.fmrUsuario_Load);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ComboBox cbmParceiroNegocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCancelar;
    }
}