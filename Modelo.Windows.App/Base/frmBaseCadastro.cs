using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo.Windows.App.Base {
    public partial class frmBaseCadastro : Form {
        public frmBaseCadastro() {
            InitializeComponent();
            gridLista.AutoGenerateColumns = false;
        }

        private void gridLista_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        public void SetaVisaoLista() {
            btnAdicionar.Visible = true;
            btnEditar.Visible = true;
            btnExcluir.Visible = true;
            btnCancelar.Visible = false;
            btnConfirmar.Visible = false;
            pnlCadastro.Enabled = false;
            pnlLista.Enabled = true;
        }

        public void SetaVisaoCadastro() {
            btnAdicionar.Visible = false;
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnCancelar.Visible = true;
            btnConfirmar.Visible = true;
            pnlCadastro.Enabled = true;
            pnlLista.Enabled = false;
        }

        public void SetaTituloForm(string titulo) {
            this.Text = titulo;
        }

        public virtual void frmBaseCadastro_Load(object sender, EventArgs e) {
            SetaVisaoLista();
        }

        public virtual void txtLocalizar_TextChanged(object sender, EventArgs e) {

        }

        public virtual void gridLista_SelectionChanged(object sender, EventArgs e) {

        }

        public virtual void btnAdicionar_Click(object sender, EventArgs e) {
            SetaVisaoCadastro();
        }

        public virtual void btnEditar_Click(object sender, EventArgs e) {
            SetaVisaoCadastro();
        }

        public virtual void btnExcluir_Click(object sender, EventArgs e) {
            SetaVisaoLista();
        }

        public virtual void btnCancelar_Click(object sender, EventArgs e) {
            SetaVisaoLista();
        }

        public virtual void btnConfirmar_Click(object sender, EventArgs e) {
            SetaVisaoLista();
        }
    }
}
