using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Modelo.ORM.DAL;
using Modelo.ORM.INFO;

namespace Modelo.ORM.BLL {
    public class ProdutoBll {

        ProdutoDal dal = new ProdutoDal();

        public ProdutoInfo Salvar(ProdutoInfo obj) {
            return dal.Salvar(obj);
        }

        public ProdutoInfo Selecionar(int produtoId) {
            return dal.Selecionar(produtoId);
        }

        public bool Excluir(int produtoId) {
            return dal.Excluir(produtoId);
        }

        public List<ProdutoInfo> SelecionarTodos() {
            return dal.SelecionarTodos();
        }

        public List<ProdutoInfo> SelecionarFiltro(string descricaoFiltro) {
            return dal.SelecionarFiltro(descricaoFiltro);
        }
    }
}
