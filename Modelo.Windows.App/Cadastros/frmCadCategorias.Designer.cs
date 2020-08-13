namespace Modelo.Windows.App.Cadastros {
    partial class frmCadCategorias {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblCod = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.pnlDados.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLista
            // 
            this.pnlLista.Size = new System.Drawing.Size(280, 450);
            // 
            // pnlDados
            // 
            this.pnlDados.Size = new System.Drawing.Size(520, 450);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Controls.Add(this.lblCategoria);
            this.pnlCadastro.Controls.Add(this.chkAtivo);
            this.pnlCadastro.Controls.Add(this.txtDescricao);
            this.pnlCadastro.Controls.Add(this.lblCod);
            this.pnlCadastro.Size = new System.Drawing.Size(510, 389);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(242, 7);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(35, 14);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "label1";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 53);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(271, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(6, 79);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(51, 18);
            this.chkAtivo.TabIndex = 2;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 34);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(53, 14);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // frmCadCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmCadCategorias";
            this.Text = "frmCadCategoria";
            this.pnlDados.ResumeLayout(false);
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblCod;
    }
}