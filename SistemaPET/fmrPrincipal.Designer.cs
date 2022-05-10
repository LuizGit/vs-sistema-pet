
namespace SistemaPET
{
    partial class fmrPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parceiroDeNegocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espécieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosPacotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusteEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercadoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parceiroDeNegocioToolStripMenuItem,
            this.produtosPacotesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parceiroDeNegocioToolStripMenuItem
            // 
            this.parceiroDeNegocioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espécieToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.pETToolStripMenuItem,
            this.serviçoToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.parceiroDeNegocioToolStripMenuItem.Name = "parceiroDeNegocioToolStripMenuItem";
            this.parceiroDeNegocioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.parceiroDeNegocioToolStripMenuItem.Text = "Cadastro";
            // 
            // espécieToolStripMenuItem
            // 
            this.espécieToolStripMenuItem.Name = "espécieToolStripMenuItem";
            this.espécieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.espécieToolStripMenuItem.Text = "Espécie";
            this.espécieToolStripMenuItem.Click += new System.EventHandler(this.espécieToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroToolStripMenuItem.Text = "Parceiro Negocio";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // pETToolStripMenuItem
            // 
            this.pETToolStripMenuItem.Name = "pETToolStripMenuItem";
            this.pETToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pETToolStripMenuItem.Text = "PET";
            this.pETToolStripMenuItem.Click += new System.EventHandler(this.pETToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // produtosPacotesToolStripMenuItem
            // 
            this.produtosPacotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajusteEstoqueToolStripMenuItem,
            this.mercadoriasToolStripMenuItem});
            this.produtosPacotesToolStripMenuItem.Name = "produtosPacotesToolStripMenuItem";
            this.produtosPacotesToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.produtosPacotesToolStripMenuItem.Text = "Produtos / Pacotes";
            // 
            // ajusteEstoqueToolStripMenuItem
            // 
            this.ajusteEstoqueToolStripMenuItem.Name = "ajusteEstoqueToolStripMenuItem";
            this.ajusteEstoqueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajusteEstoqueToolStripMenuItem.Text = "Ajuste Estoque";
            this.ajusteEstoqueToolStripMenuItem.Click += new System.EventHandler(this.ajusteEstoqueToolStripMenuItem_Click);
            // 
            // mercadoriasToolStripMenuItem
            // 
            this.mercadoriasToolStripMenuItem.Name = "mercadoriasToolStripMenuItem";
            this.mercadoriasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mercadoriasToolStripMenuItem.Text = "Mercadorias";
            this.mercadoriasToolStripMenuItem.Click += new System.EventHandler(this.mercadoriasToolStripMenuItem_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            this.serviçoToolStripMenuItem.Click += new System.EventHandler(this.serviçoToolStripMenuItem_Click);
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 508);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmrPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema PET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.fmrPrincipal_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parceiroDeNegocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espécieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosPacotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercadoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajusteEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
    }
}