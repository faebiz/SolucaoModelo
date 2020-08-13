namespace Modelo.Windows.App.Cadastros {
    partial class frmCadProdutos {
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtDescricaoReduzida = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDescricaoReduzida = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblDescontoMaximo = new System.Windows.Forms.Label();
            this.txtDescontoMaximo = new System.Windows.Forms.TextBox();
            this.chkPermiteDesconto = new System.Windows.Forms.CheckBox();
            this.chkPesavel = new System.Windows.Forms.CheckBox();
            this.chkForaDeLinha = new System.Windows.Forms.CheckBox();
            this.chkPromocao = new System.Windows.Forms.CheckBox();
            this.lblValorVenda4 = new System.Windows.Forms.Label();
            this.lblValorVenda3 = new System.Windows.Forms.Label();
            this.lblValorVenda2 = new System.Windows.Forms.Label();
            this.lblValorVenda1 = new System.Windows.Forms.Label();
            this.lblPorcentagemLucro = new System.Windows.Forms.Label();
            this.lblValorCusto = new System.Windows.Forms.Label();
            this.txtValorVenda4 = new System.Windows.Forms.TextBox();
            this.txtValorVenda3 = new System.Windows.Forms.TextBox();
            this.txtValorVenda2 = new System.Windows.Forms.TextBox();
            this.txtValorVenda1 = new System.Windows.Forms.TextBox();
            this.txtPorcentagemLucro = new System.Windows.Forms.TextBox();
            this.txtValorCusto = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblBalancaReceita = new System.Windows.Forms.Label();
            this.txtBalancaReceita = new System.Windows.Forms.TextBox();
            this.lblBalancaDiasValidade = new System.Windows.Forms.Label();
            this.lblBalancaSetor = new System.Windows.Forms.Label();
            this.txtBalancaDiasValidade = new System.Windows.Forms.TextBox();
            this.lblEstoqueMaximo = new System.Windows.Forms.Label();
            this.lblEstoqueMinimo = new System.Windows.Forms.Label();
            this.lblEstoqueAtual = new System.Windows.Forms.Label();
            this.txtBalancaSetor = new System.Windows.Forms.TextBox();
            this.txtEstoqueMaximo = new System.Windows.Forms.TextBox();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.txtEstoqueAtual = new System.Windows.Forms.TextBox();
            this.lblCodigoDeBarra = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtCodigoDeBarra = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.pnlLista.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.pnlCadastro.Controls.Add(this.txtUnidade);
            this.pnlCadastro.Controls.Add(this.tabControl);
            this.pnlCadastro.Controls.Add(this.label2);
            this.pnlCadastro.Controls.Add(this.chkAtivo);
            this.pnlCadastro.Controls.Add(this.cmbCategoria);
            this.pnlCadastro.Controls.Add(this.lblCategoria);
            this.pnlCadastro.Controls.Add(this.lblCod);
            this.pnlCadastro.Controls.Add(this.lblDescricaoReduzida);
            this.pnlCadastro.Controls.Add(this.lblDescricao);
            this.pnlCadastro.Controls.Add(this.txtDescricaoReduzida);
            this.pnlCadastro.Controls.Add(this.txtDescricao);
            this.pnlCadastro.Size = new System.Drawing.Size(510, 389);
            this.pnlCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadastro_Paint);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(122, 29);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(369, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // txtDescricaoReduzida
            // 
            this.txtDescricaoReduzida.Location = new System.Drawing.Point(122, 55);
            this.txtDescricaoReduzida.Name = "txtDescricaoReduzida";
            this.txtDescricaoReduzida.Size = new System.Drawing.Size(213, 20);
            this.txtDescricaoReduzida.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(60, 32);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(56, 14);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblDescricaoReduzida
            // 
            this.lblDescricaoReduzida.AutoSize = true;
            this.lblDescricaoReduzida.Location = new System.Drawing.Point(12, 58);
            this.lblDescricaoReduzida.Name = "lblDescricaoReduzida";
            this.lblDescricaoReduzida.Size = new System.Drawing.Size(104, 14);
            this.lblDescricaoReduzida.TabIndex = 3;
            this.lblDescricaoReduzida.Text = "Descrição Reduzida";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(350, 12);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(35, 14);
            this.lblCod.TabIndex = 4;
            this.lblCod.Text = "label1";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(63, 84);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(53, 14);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(122, 81);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(213, 22);
            this.cmbCategoria.TabIndex = 3;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(353, 80);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(51, 18);
            this.chkAtivo.TabIndex = 4;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unidade";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(15, 120);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(488, 262);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDescontoMaximo);
            this.tabPage1.Controls.Add(this.txtDescontoMaximo);
            this.tabPage1.Controls.Add(this.chkPermiteDesconto);
            this.tabPage1.Controls.Add(this.chkPesavel);
            this.tabPage1.Controls.Add(this.chkForaDeLinha);
            this.tabPage1.Controls.Add(this.chkPromocao);
            this.tabPage1.Controls.Add(this.lblValorVenda4);
            this.tabPage1.Controls.Add(this.lblValorVenda3);
            this.tabPage1.Controls.Add(this.lblValorVenda2);
            this.tabPage1.Controls.Add(this.lblValorVenda1);
            this.tabPage1.Controls.Add(this.lblPorcentagemLucro);
            this.tabPage1.Controls.Add(this.lblValorCusto);
            this.tabPage1.Controls.Add(this.txtValorVenda4);
            this.tabPage1.Controls.Add(this.txtValorVenda3);
            this.tabPage1.Controls.Add(this.txtValorVenda2);
            this.tabPage1.Controls.Add(this.txtValorVenda1);
            this.tabPage1.Controls.Add(this.txtPorcentagemLucro);
            this.tabPage1.Controls.Add(this.txtValorCusto);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Preço";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblDescontoMaximo
            // 
            this.lblDescontoMaximo.AutoSize = true;
            this.lblDescontoMaximo.Location = new System.Drawing.Point(182, 185);
            this.lblDescontoMaximo.Name = "lblDescontoMaximo";
            this.lblDescontoMaximo.Size = new System.Drawing.Size(92, 14);
            this.lblDescontoMaximo.TabIndex = 17;
            this.lblDescontoMaximo.Text = "Desconto Máximo";
            // 
            // txtDescontoMaximo
            // 
            this.txtDescontoMaximo.Location = new System.Drawing.Point(185, 202);
            this.txtDescontoMaximo.Name = "txtDescontoMaximo";
            this.txtDescontoMaximo.Size = new System.Drawing.Size(124, 20);
            this.txtDescontoMaximo.TabIndex = 10;
            // 
            // chkPermiteDesconto
            // 
            this.chkPermiteDesconto.AutoSize = true;
            this.chkPermiteDesconto.Location = new System.Drawing.Point(15, 202);
            this.chkPermiteDesconto.Name = "chkPermiteDesconto";
            this.chkPermiteDesconto.Size = new System.Drawing.Size(110, 18);
            this.chkPermiteDesconto.TabIndex = 9;
            this.chkPermiteDesconto.Text = "Permite Desconto";
            this.chkPermiteDesconto.UseVisualStyleBackColor = true;
            this.chkPermiteDesconto.CheckedChanged += new System.EventHandler(this.chkPermiteDesconto_CheckedChanged);
            // 
            // chkPesavel
            // 
            this.chkPesavel.AutoSize = true;
            this.chkPesavel.Location = new System.Drawing.Point(15, 178);
            this.chkPesavel.Name = "chkPesavel";
            this.chkPesavel.Size = new System.Drawing.Size(64, 18);
            this.chkPesavel.TabIndex = 8;
            this.chkPesavel.Text = "Pesável";
            this.chkPesavel.UseVisualStyleBackColor = true;
            // 
            // chkForaDeLinha
            // 
            this.chkForaDeLinha.AutoSize = true;
            this.chkForaDeLinha.Location = new System.Drawing.Point(15, 154);
            this.chkForaDeLinha.Name = "chkForaDeLinha";
            this.chkForaDeLinha.Size = new System.Drawing.Size(92, 18);
            this.chkForaDeLinha.TabIndex = 7;
            this.chkForaDeLinha.Text = "Fora de Linha";
            this.chkForaDeLinha.UseVisualStyleBackColor = true;
            // 
            // chkPromocao
            // 
            this.chkPromocao.AutoSize = true;
            this.chkPromocao.Location = new System.Drawing.Point(15, 130);
            this.chkPromocao.Name = "chkPromocao";
            this.chkPromocao.Size = new System.Drawing.Size(74, 18);
            this.chkPromocao.TabIndex = 6;
            this.chkPromocao.Text = "Promoção";
            this.chkPromocao.UseVisualStyleBackColor = true;
            // 
            // lblValorVenda4
            // 
            this.lblValorVenda4.AutoSize = true;
            this.lblValorVenda4.Location = new System.Drawing.Point(182, 87);
            this.lblValorVenda4.Name = "lblValorVenda4";
            this.lblValorVenda4.Size = new System.Drawing.Size(75, 14);
            this.lblValorVenda4.TabIndex = 11;
            this.lblValorVenda4.Text = "Valor Venda 4";
            // 
            // lblValorVenda3
            // 
            this.lblValorVenda3.AutoSize = true;
            this.lblValorVenda3.Location = new System.Drawing.Point(12, 87);
            this.lblValorVenda3.Name = "lblValorVenda3";
            this.lblValorVenda3.Size = new System.Drawing.Size(75, 14);
            this.lblValorVenda3.TabIndex = 10;
            this.lblValorVenda3.Text = "Valor Venda 3";
            // 
            // lblValorVenda2
            // 
            this.lblValorVenda2.AutoSize = true;
            this.lblValorVenda2.Location = new System.Drawing.Point(182, 47);
            this.lblValorVenda2.Name = "lblValorVenda2";
            this.lblValorVenda2.Size = new System.Drawing.Size(75, 14);
            this.lblValorVenda2.TabIndex = 9;
            this.lblValorVenda2.Text = "Valor Venda 2";
            // 
            // lblValorVenda1
            // 
            this.lblValorVenda1.AutoSize = true;
            this.lblValorVenda1.Location = new System.Drawing.Point(12, 47);
            this.lblValorVenda1.Name = "lblValorVenda1";
            this.lblValorVenda1.Size = new System.Drawing.Size(75, 14);
            this.lblValorVenda1.TabIndex = 8;
            this.lblValorVenda1.Text = "Valor Venda 1";
            // 
            // lblPorcentagemLucro
            // 
            this.lblPorcentagemLucro.AutoSize = true;
            this.lblPorcentagemLucro.Location = new System.Drawing.Point(182, 7);
            this.lblPorcentagemLucro.Name = "lblPorcentagemLucro";
            this.lblPorcentagemLucro.Size = new System.Drawing.Size(48, 14);
            this.lblPorcentagemLucro.TabIndex = 7;
            this.lblPorcentagemLucro.Text = "% Lucro";
            // 
            // lblValorCusto
            // 
            this.lblValorCusto.AutoSize = true;
            this.lblValorCusto.Location = new System.Drawing.Point(12, 7);
            this.lblValorCusto.Name = "lblValorCusto";
            this.lblValorCusto.Size = new System.Drawing.Size(63, 14);
            this.lblValorCusto.TabIndex = 6;
            this.lblValorCusto.Text = "Valor Custo";
            // 
            // txtValorVenda4
            // 
            this.txtValorVenda4.Location = new System.Drawing.Point(185, 104);
            this.txtValorVenda4.Name = "txtValorVenda4";
            this.txtValorVenda4.Size = new System.Drawing.Size(124, 20);
            this.txtValorVenda4.TabIndex = 5;
            // 
            // txtValorVenda3
            // 
            this.txtValorVenda3.Location = new System.Drawing.Point(15, 104);
            this.txtValorVenda3.Name = "txtValorVenda3";
            this.txtValorVenda3.Size = new System.Drawing.Size(124, 20);
            this.txtValorVenda3.TabIndex = 4;
            // 
            // txtValorVenda2
            // 
            this.txtValorVenda2.Location = new System.Drawing.Point(185, 64);
            this.txtValorVenda2.Name = "txtValorVenda2";
            this.txtValorVenda2.Size = new System.Drawing.Size(124, 20);
            this.txtValorVenda2.TabIndex = 3;
            // 
            // txtValorVenda1
            // 
            this.txtValorVenda1.Location = new System.Drawing.Point(15, 64);
            this.txtValorVenda1.Name = "txtValorVenda1";
            this.txtValorVenda1.Size = new System.Drawing.Size(124, 20);
            this.txtValorVenda1.TabIndex = 2;
            // 
            // txtPorcentagemLucro
            // 
            this.txtPorcentagemLucro.Location = new System.Drawing.Point(185, 24);
            this.txtPorcentagemLucro.Name = "txtPorcentagemLucro";
            this.txtPorcentagemLucro.Size = new System.Drawing.Size(124, 20);
            this.txtPorcentagemLucro.TabIndex = 1;
            // 
            // txtValorCusto
            // 
            this.txtValorCusto.Location = new System.Drawing.Point(15, 24);
            this.txtValorCusto.Name = "txtValorCusto";
            this.txtValorCusto.Size = new System.Drawing.Size(124, 20);
            this.txtValorCusto.TabIndex = 0;
            this.txtValorCusto.TextChanged += new System.EventHandler(this.txtValorCusto_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblBalancaReceita);
            this.tabPage2.Controls.Add(this.txtBalancaReceita);
            this.tabPage2.Controls.Add(this.lblBalancaDiasValidade);
            this.tabPage2.Controls.Add(this.lblBalancaSetor);
            this.tabPage2.Controls.Add(this.txtBalancaDiasValidade);
            this.tabPage2.Controls.Add(this.lblEstoqueMaximo);
            this.tabPage2.Controls.Add(this.lblEstoqueMinimo);
            this.tabPage2.Controls.Add(this.lblEstoqueAtual);
            this.tabPage2.Controls.Add(this.txtBalancaSetor);
            this.tabPage2.Controls.Add(this.txtEstoqueMaximo);
            this.tabPage2.Controls.Add(this.txtEstoqueMinimo);
            this.tabPage2.Controls.Add(this.txtEstoqueAtual);
            this.tabPage2.Controls.Add(this.lblCodigoDeBarra);
            this.tabPage2.Controls.Add(this.lblReferencia);
            this.tabPage2.Controls.Add(this.lblModelo);
            this.tabPage2.Controls.Add(this.lblMarca);
            this.tabPage2.Controls.Add(this.txtCodigoDeBarra);
            this.tabPage2.Controls.Add(this.txtReferencia);
            this.tabPage2.Controls.Add(this.txtModelo);
            this.tabPage2.Controls.Add(this.txtMarca);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estoque";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblBalancaReceita
            // 
            this.lblBalancaReceita.AutoSize = true;
            this.lblBalancaReceita.Location = new System.Drawing.Point(7, 166);
            this.lblBalancaReceita.Name = "lblBalancaReceita";
            this.lblBalancaReceita.Size = new System.Drawing.Size(85, 14);
            this.lblBalancaReceita.TabIndex = 19;
            this.lblBalancaReceita.Text = "Balança Receita";
            // 
            // txtBalancaReceita
            // 
            this.txtBalancaReceita.Location = new System.Drawing.Point(6, 180);
            this.txtBalancaReceita.Multiline = true;
            this.txtBalancaReceita.Name = "txtBalancaReceita";
            this.txtBalancaReceita.Size = new System.Drawing.Size(466, 49);
            this.txtBalancaReceita.TabIndex = 9;
            // 
            // lblBalancaDiasValidade
            // 
            this.lblBalancaDiasValidade.AutoSize = true;
            this.lblBalancaDiasValidade.Location = new System.Drawing.Point(124, 128);
            this.lblBalancaDiasValidade.Name = "lblBalancaDiasValidade";
            this.lblBalancaDiasValidade.Size = new System.Drawing.Size(114, 14);
            this.lblBalancaDiasValidade.TabIndex = 17;
            this.lblBalancaDiasValidade.Text = "Balança Dias Validade";
            // 
            // lblBalancaSetor
            // 
            this.lblBalancaSetor.AutoSize = true;
            this.lblBalancaSetor.Location = new System.Drawing.Point(7, 128);
            this.lblBalancaSetor.Name = "lblBalancaSetor";
            this.lblBalancaSetor.Size = new System.Drawing.Size(75, 14);
            this.lblBalancaSetor.TabIndex = 16;
            this.lblBalancaSetor.Text = "Balança Setor";
            // 
            // txtBalancaDiasValidade
            // 
            this.txtBalancaDiasValidade.Location = new System.Drawing.Point(127, 143);
            this.txtBalancaDiasValidade.Name = "txtBalancaDiasValidade";
            this.txtBalancaDiasValidade.Size = new System.Drawing.Size(100, 20);
            this.txtBalancaDiasValidade.TabIndex = 8;
            // 
            // lblEstoqueMaximo
            // 
            this.lblEstoqueMaximo.AutoSize = true;
            this.lblEstoqueMaximo.Location = new System.Drawing.Point(245, 88);
            this.lblEstoqueMaximo.Name = "lblEstoqueMaximo";
            this.lblEstoqueMaximo.Size = new System.Drawing.Size(85, 14);
            this.lblEstoqueMaximo.TabIndex = 14;
            this.lblEstoqueMaximo.Text = "Estoque Máximo";
            // 
            // lblEstoqueMinimo
            // 
            this.lblEstoqueMinimo.AutoSize = true;
            this.lblEstoqueMinimo.Location = new System.Drawing.Point(124, 88);
            this.lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            this.lblEstoqueMinimo.Size = new System.Drawing.Size(81, 14);
            this.lblEstoqueMinimo.TabIndex = 13;
            this.lblEstoqueMinimo.Text = "Estoque Mínimo";
            // 
            // lblEstoqueAtual
            // 
            this.lblEstoqueAtual.AutoSize = true;
            this.lblEstoqueAtual.Location = new System.Drawing.Point(7, 88);
            this.lblEstoqueAtual.Name = "lblEstoqueAtual";
            this.lblEstoqueAtual.Size = new System.Drawing.Size(73, 14);
            this.lblEstoqueAtual.TabIndex = 12;
            this.lblEstoqueAtual.Text = "Estoque Atual";
            // 
            // txtBalancaSetor
            // 
            this.txtBalancaSetor.Location = new System.Drawing.Point(7, 143);
            this.txtBalancaSetor.Name = "txtBalancaSetor";
            this.txtBalancaSetor.Size = new System.Drawing.Size(100, 20);
            this.txtBalancaSetor.TabIndex = 7;
            // 
            // txtEstoqueMaximo
            // 
            this.txtEstoqueMaximo.Location = new System.Drawing.Point(247, 105);
            this.txtEstoqueMaximo.Name = "txtEstoqueMaximo";
            this.txtEstoqueMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtEstoqueMaximo.TabIndex = 6;
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(127, 105);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtEstoqueMinimo.TabIndex = 5;
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.Location = new System.Drawing.Point(7, 105);
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.Size = new System.Drawing.Size(100, 20);
            this.txtEstoqueAtual.TabIndex = 4;
            // 
            // lblCodigoDeBarra
            // 
            this.lblCodigoDeBarra.AutoSize = true;
            this.lblCodigoDeBarra.Location = new System.Drawing.Point(245, 48);
            this.lblCodigoDeBarra.Name = "lblCodigoDeBarra";
            this.lblCodigoDeBarra.Size = new System.Drawing.Size(85, 14);
            this.lblCodigoDeBarra.TabIndex = 7;
            this.lblCodigoDeBarra.Text = "Código de Barra";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(7, 48);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(60, 14);
            this.lblReferencia.TabIndex = 6;
            this.lblReferencia.Text = "Referência";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(245, 8);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(41, 14);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(7, 7);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 14);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // txtCodigoDeBarra
            // 
            this.txtCodigoDeBarra.Location = new System.Drawing.Point(248, 65);
            this.txtCodigoDeBarra.Name = "txtCodigoDeBarra";
            this.txtCodigoDeBarra.Size = new System.Drawing.Size(226, 20);
            this.txtCodigoDeBarra.TabIndex = 3;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(7, 65);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(226, 20);
            this.txtReferencia.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(248, 25);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(226, 20);
            this.txtModelo.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(7, 25);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(226, 20);
            this.txtMarca.TabIndex = 0;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(411, 56);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(80, 20);
            this.txtUnidade.TabIndex = 2;
            // 
            // frmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmCadProdutos";
            this.Text = "frmCadProdutos";
            this.Load += new System.EventHandler(this.frmCadProdutos_Load);
            this.pnlLista.ResumeLayout(false);
            this.pnlLista.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblDescricaoReduzida;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricaoReduzida;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.Label lblValorVenda1;
        private System.Windows.Forms.Label lblPorcentagemLucro;
        private System.Windows.Forms.Label lblValorCusto;
        private System.Windows.Forms.TextBox txtValorVenda4;
        private System.Windows.Forms.TextBox txtValorVenda3;
        private System.Windows.Forms.TextBox txtValorVenda2;
        private System.Windows.Forms.TextBox txtValorVenda1;
        private System.Windows.Forms.TextBox txtPorcentagemLucro;
        private System.Windows.Forms.TextBox txtValorCusto;
        private System.Windows.Forms.Label lblDescontoMaximo;
        private System.Windows.Forms.TextBox txtDescontoMaximo;
        private System.Windows.Forms.CheckBox chkPermiteDesconto;
        private System.Windows.Forms.CheckBox chkPesavel;
        private System.Windows.Forms.CheckBox chkForaDeLinha;
        private System.Windows.Forms.CheckBox chkPromocao;
        private System.Windows.Forms.Label lblValorVenda4;
        private System.Windows.Forms.Label lblValorVenda3;
        private System.Windows.Forms.Label lblValorVenda2;
        private System.Windows.Forms.TextBox txtCodigoDeBarra;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblCodigoDeBarra;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblEstoqueMaximo;
        private System.Windows.Forms.Label lblEstoqueMinimo;
        private System.Windows.Forms.Label lblEstoqueAtual;
        private System.Windows.Forms.TextBox txtBalancaSetor;
        private System.Windows.Forms.TextBox txtEstoqueMaximo;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.TextBox txtEstoqueAtual;
        private System.Windows.Forms.Label lblBalancaReceita;
        private System.Windows.Forms.TextBox txtBalancaReceita;
        private System.Windows.Forms.Label lblBalancaDiasValidade;
        private System.Windows.Forms.Label lblBalancaSetor;
        private System.Windows.Forms.TextBox txtBalancaDiasValidade;
    }
}