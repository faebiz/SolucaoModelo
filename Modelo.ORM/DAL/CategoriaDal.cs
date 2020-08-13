using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using Modelo.ORM.INFO;
using Dapper;

namespace Modelo.ORM.DAL {
    public class CategoriaDal {
        public IDbConnection conexao { get; set; }

        public CategoriaDal() {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString);
        }

        const string sqlInserir = @"INSERT INTO Categoria (Descricao, IsAtivo) 
                                         VALUES (@Descricao, @IsAtivo);
                                         SELECT * 
                                           FROM Categoria 
                                          WHERE CategoriaID = scope_identity()";

        const string sqlAtualizar = @"UPDATE Categoria 
                                         SET Descricao = @Descricao, IsAtivo = @IsAtivo 
                                       WHERE CategoriaID = @CategoriaID";

        const string sqlExcluir = @"DELETE FROM Categoria
                                          WHERE CategoriaID = @CategoriaID";

        const string sqlSelecionar = @"SELECT *
                                         FROM Categoria
                                        WHERE CategoriaID = @CategoriaID";

        const string sqlSelecionarTodos = @"SELECT *
                                              FROM Categoria
                                          ORDER BY Descricao";

        const string sqlSelecionarFiltro = @"SELECT * 
                                               FROM Categoria
                                              WHERE Descricao LIKE @Descricao
                                           ORDER BY Descricao";

        public CategoriaInfo Salvar(CategoriaInfo categInfo) {
            if (categInfo.CategoriaID == 0) {
                return conexao.Query<CategoriaInfo>(sqlInserir, categInfo).SingleOrDefault();
            } else {
                conexao.Query<CategoriaInfo>(sqlAtualizar, categInfo);
                return categInfo;
            }
        }

        public bool Excluir(int categId) {
            return conexao.Execute(sqlExcluir, new { CategoriaID = categId }) > 0;
        }

        public CategoriaInfo Selecionar(int categid) {
            return conexao.Query<CategoriaInfo>(sqlSelecionar, new { CategoriaID = categid }).SingleOrDefault();
        }

        public List<CategoriaInfo> SelecionarTodos() {
            return conexao.Query<CategoriaInfo>(sqlSelecionarTodos, null).ToList();
        }

        public List<CategoriaInfo> SelecionarFiltro(string pDescricao) {
            return conexao.Query<CategoriaInfo>(sqlSelecionarFiltro, new { @Descricao = "%" + pDescricao + "%"}).ToList();
        }

    }
}
