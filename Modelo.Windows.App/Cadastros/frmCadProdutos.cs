using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Modelo.Windows.App.Base;
using Modelo.Helper;
using Modelo.ORM.BLL;
using Modelo.ORM.INFO;

namespace Modelo.Windows.App.Cadastros {
    public partial class frmCadProdutos : frmBaseCadastro {
        CategoriaBll categoriaBll = new CategoriaBll();
        ProdutoBll produtoBll = new ProdutoBll();
        ConvertHelper convert = new ConvertHelper();
        public frmCadProdutos() {
            InitializeComponent();
        }

        private void pnlCadastro_Paint(object sender, PaintEventArgs e) {

        }      

        private void frmCadProdutos_Load(object sender, EventArgs e) {
            SetaTituloForm("Cadastro de Produtos");

            cmbCategoria.DataSource = categoriaBll.SelecionarTodos();
            cmbCategoria.DisplayMember = "Descricao";
            cmbCategoria.ValueMember = "CategoriaID";
            cmbCategoria.Refresh();

            gridLista.DataSource = produtoBll.SelecionarTodos();
            base.frmBaseCadastro_Load(sender, e);
        }

        public override void btnAdicionar_Click(object sender, EventArgs e) {
            LimpaCampos();
            base.btnAdicionar_Click(sender, e);
        }

        public override void btnEditar_Click(object sender, EventArgs e) {
            base.btnEditar_Click(sender, e);
        }

        public override void btnExcluir_Click(object sender, EventArgs e) {
            if (gridLista.SelectedRows.Count > 0) {

                ProdutoInfo produtoSelecionado = (ProdutoInfo)gridLista.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show(string.Format("Deseja Excluir {0}?", produtoSelecionado.DescPadrao), "Atenção", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                    produtoBll.Excluir(produtoSelecionado.ProdutoID);
                    gridLista.DataSource = produtoBll.SelecionarTodos();
                    MessageBox.Show("Item excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } else {
                MessageBox.Show("Favor selecionar um item para excluir");
            }

            LimpaCampos();
            base.btnExcluir_Click(sender, e);
        }

        public override void btnCancelar_Click(object sender, EventArgs e) {
            LimpaCampos();
            base.btnCancelar_Click(sender, e);
        }
        public override void btnConfirmar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtDescricao.Text)) {
                MessageBox.Show("Obrigatório inserir a Descrição", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();

            } else if (String.IsNullOrEmpty(txtDescricaoReduzida.Text)) {
                MessageBox.Show("Obrigatório inserir a Descrição Reduzida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricaoReduzida.Focus();

            } else if (String.IsNullOrEmpty(txtValorCusto.Text)) {
                MessageBox.Show("Obrigatório inserir o Valor de Custo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorCusto.Focus();

            } else {
                ProdutoInfo produto = new ProdutoInfo();
                produto.ProdutoID = lblCod.Text == "" ? 0 : convert.ConvertToInt32(lblCod.Text);
                produto.Descricao = txtDescricao.Text;
                produto.IsAtivo = convert.ConvertToBool(chkAtivo.Checked);
                produto.Unidade = txtUnidade.Text;
                produto.CategoriaID = convert.ConvertToInt32(cmbCategoria.SelectedValue);
                produto.DescricaoReduzida = txtDescricaoReduzida.Text;
                produto.ValorCusto = convert.ConvertToDecimal(txtValorCusto.Text);
                produto.PorcentagemLucro = convert.ConvertToDecimal(txtPorcentagemLucro.Text);
                produto.ValorVenda1 = convert.ConvertToDecimal(txtValorVenda1.Text);
                produto.ValorVenda2 = convert.ConvertToDecimal(txtValorVenda2.Text);
                produto.ValorVenda3 = convert.ConvertToDecimal(txtValorVenda3.Text);
                produto.ValorVenda4 = convert.ConvertToDecimal(txtValorVenda4.Text);
                produto.IsPromocao = convert.ConvertToBool(chkPromocao.Checked);
                produto.IsForaDeLinha = convert.ConvertToBool(chkForaDeLinha.Checked);
                produto.IsPesavel = convert.ConvertToBool(chkPesavel.Checked);
                produto.IsPermiteDesconto = convert.ConvertToBool(chkPermiteDesconto.Checked);
                produto.DescontoMaximo = convert.ConvertToDecimal(txtDescontoMaximo.Text);
                produto.Marca = txtMarca.Text;
                produto.Modelo = txtModelo.Text;
                produto.Referencia = txtReferencia.Text;
                produto.CodigoBarra = txtCodigoDeBarra.Text;
                produto.EstoqueAtual = convert.ConvertToDecimal(txtEstoqueAtual.Text);
                produto.EstoqueMinimo = convert.ConvertToDecimal(txtEstoqueMinimo.Text);
                produto.EstoqueMaximo = convert.ConvertToDecimal(txtEstoqueMaximo.Text);
                produto.BalancaSetor = convert.ConvertToInt32(txtBalancaSetor.Text);
                produto.BalancaDiasValidade = convert.ConvertToInt32(txtBalancaDiasValidade.Text);
                produto.BalancaReceita = txtBalancaReceita.Text;

                produtoBll.Salvar(produto);
                LimpaCampos();
                gridLista.DataSource = produtoBll.SelecionarTodos();
            }
            base.btnConfirmar_Click(sender, e);
        }
        public override void gridLista_SelectionChanged(object sender, EventArgs e) {
            if (gridLista.SelectedRows.Count > 0) {
                ProdutoInfo produtoSelecionado = (ProdutoInfo)gridLista.SelectedRows[0].DataBoundItem;
                lblCod.Text = produtoSelecionado.ProdutoID.ToString();
                txtDescricao.Text = produtoSelecionado.Descricao;
                txtDescricaoReduzida.Text = produtoSelecionado.DescricaoReduzida;
                txtUnidade.Text = produtoSelecionado.Unidade;
                chkAtivo.Checked = produtoSelecionado.IsAtivo;
                cmbCategoria.SelectedValue = produtoSelecionado.CategoriaID;
                //Preço
                txtValorCusto.Text = produtoSelecionado.ValorCusto.ToString();
                txtPorcentagemLucro.Text = produtoSelecionado.PorcentagemLucro.ToString();
                txtValorVenda1.Text = produtoSelecionado.ValorVenda1.ToString();
                txtValorVenda2.Text = produtoSelecionado.ValorVenda2.ToString();
                txtValorVenda3.Text = produtoSelecionado.ValorVenda3.ToString();
                txtValorVenda4.Text = produtoSelecionado.ValorVenda4.ToString();
                chkPromocao.Checked = produtoSelecionado.IsPromocao;
                chkPesavel.Checked = produtoSelecionado.IsPesavel;
                chkForaDeLinha.Checked = produtoSelecionado.IsForaDeLinha;
                chkPermiteDesconto.Checked = produtoSelecionado.IsPermiteDesconto;
                txtDescontoMaximo.Text = produtoSelecionado.DescontoMaximo.ToString();
                //Estoque
                txtMarca.Text = produtoSelecionado.Marca;
                txtModelo.Text = produtoSelecionado.Modelo;
                txtReferencia.Text = produtoSelecionado.Referencia;
                txtCodigoDeBarra.Text = produtoSelecionado.CodigoBarra;
                txtEstoqueAtual.Text = produtoSelecionado.EstoqueAtual.ToString();
                txtEstoqueMinimo.Text = produtoSelecionado.EstoqueMinimo.ToString();
                txtEstoqueMaximo.Text = produtoSelecionado.EstoqueMaximo.ToString();
                txtBalancaSetor.Text = produtoSelecionado.BalancaSetor.ToString();
                txtBalancaDiasValidade.Text = produtoSelecionado.BalancaDiasValidade.ToString();
                txtBalancaReceita.Text = produtoSelecionado.BalancaReceita;
            }
            base.gridLista_SelectionChanged(sender, e);
        }

        public override void txtLocalizar_TextChanged(object sender, EventArgs e) {
            gridLista.DataSource = produtoBll.SelecionarFiltro(txtLocalizar.Text);
            base.txtLocalizar_TextChanged(sender, e);
        }

        private void LimpaCampos() {
            lblCod.Text = "";
            txtDescricao.Clear();
            txtDescricaoReduzida.Clear();
            txtUnidade.Clear();
            chkAtivo.Checked = true;
            //Preço
            txtValorCusto.Clear();
            txtPorcentagemLucro.Clear();
            txtValorVenda1.Clear();
            txtValorVenda2.Clear();
            txtValorVenda3.Clear();
            txtValorVenda4.Clear();
            chkPromocao.Checked = false;
            chkPesavel.Checked = false;
            chkForaDeLinha.Checked = false;
            chkPermiteDesconto.Checked = false;
            txtDescontoMaximo.Clear();
            //Estoque
            txtMarca.Clear();
            txtModelo.Clear();
            txtReferencia.Clear();
            txtCodigoDeBarra.Clear();
            txtEstoqueAtual.Clear();
            txtEstoqueMinimo.Clear();
            txtEstoqueMaximo.Clear();
            txtBalancaSetor.Clear();
            txtBalancaDiasValidade.Clear();
            txtBalancaReceita.Clear();
        }

        private void chkPermiteDesconto_CheckedChanged(object sender, EventArgs e) {

        }

        private void txtValorCusto_TextChanged(object sender, EventArgs e) {

        }
    }
}
