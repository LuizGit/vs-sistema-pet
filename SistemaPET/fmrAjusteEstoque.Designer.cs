
namespace SistemaPET
{
    partial class fmrAjusteEstoque
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
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdMercadoria = new System.Windows.Forms.TextBox();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.gpbRegistros = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmTipo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.btnCancelar);
            this.gpbDados.Controls.Add(this.btnSalvar);
            this.gpbDados.Controls.Add(this.cbmTipo);
            this.gpbDados.Controls.Add(this.label4);
            this.gpbDados.Controls.Add(this.txtQtd);
            this.gpbDados.Controls.Add(this.label3);
            this.gpbDados.Controls.Add(this.txtIdMercadoria);
            this.gpbDados.Controls.Add(this.lblCodBarras);
            this.gpbDados.Controls.Add(this.label2);
            this.gpbDados.Controls.Add(this.lblDescricao);
            this.gpbDados.Controls.Add(this.label1);
            this.gpbDados.Location = new System.Drawing.Point(5, 5);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(378, 246);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Entrada / Saida";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(79, 88);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(97, 20);
            this.txtQtd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade:";
            // 
            // txtIdMercadoria
            // 
            this.txtIdMercadoria.Location = new System.Drawing.Point(317, 19);
            this.txtIdMercadoria.Name = "txtIdMercadoria";
            this.txtIdMercadoria.ReadOnly = true;
            this.txtIdMercadoria.Size = new System.Drawing.Size(33, 20);
            this.txtIdMercadoria.TabIndex = 4;
            this.txtIdMercadoria.Visible = false;
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Location = new System.Drawing.Point(77, 50);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(16, 13);
            this.lblCodBarras.TabIndex = 3;
            this.lblCodBarras.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cod. Barras:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(65, 28);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(16, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Location = new System.Drawing.Point(389, 5);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(475, 246);
            this.gpbPesquisa.TabIndex = 1;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa";
            // 
            // gpbRegistros
            // 
            this.gpbRegistros.Location = new System.Drawing.Point(5, 257);
            this.gpbRegistros.Name = "gpbRegistros";
            this.gpbRegistros.Size = new System.Drawing.Size(859, 305);
            this.gpbRegistros.TabIndex = 2;
            this.gpbRegistros.TabStop = false;
            this.gpbRegistros.Text = "Histórico de Movimentações";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo:";
            // 
            // cbmTipo
            // 
            this.cbmTipo.FormattingEnabled = true;
            this.cbmTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbmTipo.Location = new System.Drawing.Point(241, 88);
            this.cbmTipo.Name = "cbmTipo";
            this.cbmTipo.Size = new System.Drawing.Size(109, 21);
            this.cbmTipo.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(275, 192);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(42, 192);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // fmrAjusteEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 574);
            this.Controls.Add(this.gpbRegistros);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.gpbDados);
            this.Name = "fmrAjusteEstoque";
            this.Text = "Ajuste de estoque";
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdMercadoria;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.GroupBox gpbRegistros;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbmTipo;
        private System.Windows.Forms.Label label4;
    }
}