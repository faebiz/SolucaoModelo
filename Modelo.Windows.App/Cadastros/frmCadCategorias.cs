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
    public partial class frmCadCategorias : frmBaseCadastro {

        CategoriaBll categoriaBll = new CategoriaBll();
        ConvertHelper convert = new ConvertHelper();
        public frmCadCategorias() {
            InitializeComponent();
        }

        public override void frmBaseCadastro_Load(object sender, EventArgs e) {
            SetaTituloForm("Cadastro das Categorias");
            gridLista.DataSource = categoriaBll.SelecionarTodos();
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

                CategoriaInfo categoriaSelecionada = (CategoriaInfo)gridLista.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show(string.Format("Deseja Excluir {0}?", categoriaSelecionada.DescPadrao), "Atenção", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                    categoriaBll.Excluir(categoriaSelecionada.CategoriaID);
                    gridLista.DataSource = categoriaBll.SelecionarTodos();
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
                MessageBox.Show("Obrigatório inserir a Categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else {
                CategoriaInfo categoria = new CategoriaInfo();
                categoria.Descricao = txtDescricao.Text;
                categoria.IsAtivo = convert.ConvertToBool(chkAtivo.Checked);
                categoria.CategoriaID = lblCod.Text == "" ? 0 : convert.ConvertToInt32(lblCod.Text);

                categoriaBll.Salvar(categoria);
                LimpaCampos();
                gridLista.DataSource = categoriaBll.SelecionarTodos();
            }
            base.btnConfirmar_Click(sender, e);
        }

        public override void gridLista_SelectionChanged(object sender, EventArgs e) {
            if (gridLista.SelectedRows.Count > 0) {
                CategoriaInfo categoriaSelecionada = (CategoriaInfo)gridLista.SelectedRows[0].DataBoundItem;
                lblCod.Text = categoriaSelecionada.CategoriaID.ToString();
                txtDescricao.Text = categoriaSelecionada.Descricao;
                chkAtivo.Checked = categoriaSelecionada.IsAtivo;
            }
            base.gridLista_SelectionChanged(sender, e);
        }

        public override void txtLocalizar_TextChanged(object sender, EventArgs e) {
            gridLista.DataSource = categoriaBll.SelecionarFiltro(txtLocalizar.Text);
            base.txtLocalizar_TextChanged(sender, e);
        }

        private void LimpaCampos() {
            lblCod.Text = "";
            txtDescricao.Clear();
            chkAtivo.Checked = true;
        }
    }
}
