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
    public class ProdutoDal {
        public IDbConnection conexao { get; set; }

        public ProdutoDal() {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString);
        }     

        const string sqlInserir = @"INSERT INTO Produto (CategoriaID 
													  ,  Descricao                                                        
	                                                  ,  DescricaoReduzida
	                                                  ,  Unidade 
	                                                  ,  ValorCusto 
	                                                  ,  PorcentagemLucro
	                                                  ,  ValorVenda1
	                                                  ,  ValorVenda2
	                                                  ,  ValorVenda3
	                                                  ,  ValorVenda4
	                                                  ,  IsPromocao
													  ,  IsForaDeLinha
	                                                  ,  IsPesavel 
	                                                  ,  Marca 
	                                                  ,  Modelo
	                                                  ,  Referencia 
	                                                  ,  CodigoBarra 
	                                                  ,  IsPermiteDesconto 
	                                                  ,  DescontoMaximo 
	                                                  ,  EstoqueAtual 
	                                                  ,  EstoqueMinimo
	                                                  ,  EstoqueMaximo
	                                                  ,  BalancaSetor
	                                                  ,  BalancaDiasValidade 
	                                                  ,  BalancaReceita
													  ,  IsAtivo
	                                                  ,  Foto) 
                                         VALUES (@CategoriaID
											  ,  @Descricao                                                 
											  ,  @DescricaoReduzida
											  ,  @Unidade 
											  ,  @ValorCusto 
											  ,  @PorcentagemLucro
											  ,  @ValorVenda1
											  ,  @ValorVenda2
											  ,  @ValorVenda3
											  ,  @ValorVenda4
											  ,  @IsPromocao
											  ,  @IsForaDeLinha
											  ,  @IsPesavel 
											  ,  @Marca 
											  ,  @Modelo
											  ,  @Referencia 
											  ,  @CodigoBarra 
											  ,  @IsPermiteDesconto 
											  ,  @DescontoMaximo 
											  ,  @EstoqueAtual 
											  ,  @EstoqueMinimo
											  ,  @EstoqueMaximo
											  ,  @BalancaSetor
											  ,  @BalancaDiasValidade 
											  ,  @BalancaReceita 
										      ,  @IsAtivo
											  ,  @Foto);
                                         SELECT * 
                                           FROM Produto 
                                          WHERE ProdutoID = scope_identity()";

        const string sqlAtualizar = @"UPDATE Produto 
                                         SET CategoriaID = @CategoriaID
										   , Descricao = @Descricao                                                 
										   , DescricaoReduzida = @DescricaoReduzida
										   , Unidade = @Unidade 
										   , ValorCusto  = @ValorCusto 
										   , PorcentagemLucro = @PorcentagemLucro
										   , ValorVenda1 = @ValorVenda1
										   , ValorVenda2 = @ValorVenda2
										   , ValorVenda3 = @ValorVenda3
										   , ValorVenda4 = @ValorVenda4
										   , IsPromocao = @IsPromocao
										   , IsForaDeLinha = @IsForaDeLinha
										   , IsPesavel  = @IsPesavel 
										   , Marca  = @Marca 
										   , Modelo = @Modelo
										   , Referencia  = @Referencia 
										   , CodigoBarra  = @CodigoBarra 
										   , IsPermiteDesconto  = @IsPermiteDesconto 
										   , DescontoMaximo  = @DescontoMaximo 
										   , EstoqueAtual  = @EstoqueAtual 
										   , EstoqueMinimo = @EstoqueMinimo
										   , EstoqueMaximo = @EstoqueMaximo
										   , BalancaSetor = @BalancaSetor
										   , BalancaDiasValidade = @BalancaDiasValidade 
										   , BalancaReceita  = @BalancaReceita 
										   , IsAtivo = @IsAtivo
										   , Foto = @Foto 
                                       WHERE ProdutoID = @ProdutoID";

        const string sqlExcluir = @"DELETE FROM Produto
                                          WHERE ProdutoID = @ProdutoID";

        const string sqlSelecionar = @"SELECT *
                                         FROM Produto
                                        WHERE ProdutoID = @ProdutoID";

        const string sqlSelecionarTodos = @"SELECT *
                                              FROM Produto
                                          ORDER BY Descricao";

		const string sqlSelecionarFiltro = @"SELECT *
											   FROM Produto
											  WHERE Descricao LIKE @Descricao
										   ORDER BY Descricao";

        public ProdutoInfo Salvar(ProdutoInfo prodInfo) {
            if (prodInfo.ProdutoID == 0) {
                return conexao.Query<ProdutoInfo>(sqlInserir, prodInfo).SingleOrDefault();
            } else {
                conexao.Query<ProdutoInfo>(sqlAtualizar, prodInfo);
                return prodInfo;
            }
        }

        public bool Excluir(int prodId) {
            return conexao.Execute(sqlExcluir, new { ProdutoID = prodId }) > 0;
        }

        public ProdutoInfo Selecionar(int prodId) {
            return conexao.Query<ProdutoInfo>(sqlSelecionar, new { ProdutoID = prodId }).SingleOrDefault();
        }

        public List<ProdutoInfo> SelecionarTodos() {
            return conexao.Query<ProdutoInfo>(sqlSelecionarTodos, null).ToList();
        }

		public List<ProdutoInfo> SelecionarFiltro(string pDescricao) {
			return conexao.Query<ProdutoInfo>(sqlSelecionarFiltro, new { @Descricao = "%" + pDescricao + "%"}).ToList();
		}
	}
}
