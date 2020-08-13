using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Modelo.Windows.App.Cadastros;

namespace Modelo.Windows.App {
    public partial class frmMenu : Form {
        public frmMenu() {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e) {
            using (frmCadCategorias frmCategoria = new frmCadCategorias()) {
                frmCategoria.ShowDialog();
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e) {
            using (frmCadProdutos frmProduto = new frmCadProdutos()) {
                frmProduto.ShowDialog();
            }
        }
    }
}
