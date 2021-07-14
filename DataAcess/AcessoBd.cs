using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entities;
using Dapper;
using DataAcess.Properties;

namespace DataAcess
{
    public class AcessoBd
    {
        private SqlConnection Connection()
        {            
            return new SqlConnection(Settings.Default.StringCon);
        }
        
        public List<Fornecedores> GetFornecedores()
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<Fornecedores>(@"SELECT IdFornecedor,Fornecedor,Telefone,WhatsApp,Email FROM Fornecedores")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<VW_ProdutoGrid> GetProdutosView()
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<VW_ProdutoGrid>(@"Select IdProduto, Produto, Categoria, Tipo, Marca, Modelo, Descricao, ValorCompra, ValorVenda, Estoque, EstoqueMin, Estado from VW_ProdutosGrid")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Compras> GetCompras()
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<Compras>(@"Select IdCompra, DataCompra, Compra, NotaFiscal, ValorFrete, ValorTotal, Fornecedor From VW_Compras")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Produtos> GetProdutos()
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<Produtos>(@"SELECT IdProduto, Id_Categoria, Id_Tipo, Id_Marca, Id_Modelo, Produto, Descricao, ValorCompra, ValorVenda, Estoque, Estado FROM Produtos")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Produtos> GetEstoqueProdutoById(int idProd)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<Produtos>(@"SELECT IdProduto, Estoque, Estado FROM Produtos Where IdProduto = @idProd", new { idProd })).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<VW_ProdutosString> GetProdutosString()
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<VW_ProdutosString>(@"SELECT IdProduto, Produto, Descricao, ValorCompra, ValorVenda, Estoque, Estado FROM VW_ProdutosString")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Categorias> GetCategorias()
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<Categorias>(@"SELECT IdCategoria, Categoria FROM Categorias")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Tipos> GetTipos()
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<Tipos>(@"SELECT IdTipo, Id_Marca, Tipo FROM Tipos")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Marcas> GetMarcas()
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<Marcas>(@"SELECT IdMarca, Id_Modelo, Marca FROM Marcas")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Modelos> GetModelos()
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<Modelos>(@"SELECT IdModelo, Modelo FROM Modelos")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Clientes> GetClientes()
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<Clientes>(@"Select IdCliente, Nome, Sexo, Cpf, Email, Telefone, WhatsApp From Clientes")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<VW_Vendas> GetVendasGrid()
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<VW_Vendas>(@"Select IdVenda, IdVendedor, IdCliente, NomeCli, NomeVendedor, DataVenda, TipoComprovante, NumeroComprovante, Total, TipoVenda From VW_GridVendas")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<VW_ProdutosVenda> GetProdutosVenda(int idVenda)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<VW_ProdutosVenda>(@"Select IdProduto_Venda, Id_Produto, Id_Venda, Produto, ValorVenda, Quantidade, SubTotal From VW_ProdutosVenda Where Id_Venda = @idVenda", new { idVenda })).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Vendedores> GetVendedores()
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<Vendedores>(@"Select IdVendedor, Nome, Email, Telefone, WhatsApp, Sexo From Vendedores")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Compras_Produtos> GetProdutosCompra(int idCompra)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    return (Connection().Query<Compras_Produtos>(@"Select Id_Produto, Produto, ValorUnidade, Quantidade, SubTotal from VW_ProdutosCompra Where Id_Compra = @idCompra", new { idCompra})).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }


        ///////////////////////////////// Inserts ////////////////////////////////

        public int InsertCompra(Compras c)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    var id = Connection().ExecuteScalar(@"Execute SP_NovaCompra @Id_Fornecedor, @DataCompra, @Compra, @ValorTotal, @ValorFrete, @NotaFiscal",
                        new { c.Id_Fornecedor, c.DataCompra, c.Compra, c.ValorFrete, c.ValorTotal, c.NotaFiscal });
                    return Convert.ToInt32(id);                    
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void InsertCompra_Produto(Compras_Produtos cp)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    Connection().Execute(@"Insert into Compras_Produtos values(@Id_Compra, @Id_Produto, @ValorUnidade, @Quantidade, @SubTotal)",
                        new { cp.Id_Compra, cp.Id_Produto, cp.ValorUnidade, cp.Quantidade, cp.SubTotal });                    
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void InsertProduto(Produtos p)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    Connection().Execute(@"Insert into Produtos values(@Id_Categoria, @Id_Tipo, @Id_Marca, @Id_Modelo, @Produto,
                                         @Descricao, @ValorCompra, @ValorVenda, @Estoque, @Estado, @EstoqueMin)",
                        new { p.Id_Categoria, p.Id_Tipo, p.Id_Marca, p.Id_Modelo, p.Produto, p.Descricao, p.ValorCompra, p.ValorVenda,
                        p.Estoque, p.Estado, p.EstoqueMin});
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public int InsertCategoria(Categorias c)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    var id = Connection().ExecuteScalar(@"Execute SP_InsertCategoria @Categoria", new { c.Categoria });
                    return Convert.ToInt32(id);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public int InsertTipo(Tipos t)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    var id = Connection().ExecuteScalar(@"Execute SP_InsertTipo @Tipo", new { t.Tipo });
                    return Convert.ToInt32(id);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public int InsertMarca(Marcas m)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    var id = Connection().ExecuteScalar(@"Execute SP_InsertMarca @Marca", new { m.Marca });
                    return Convert.ToInt32(id);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public int InsertModelo(Modelos m)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    var id = Connection().ExecuteScalar(@"Execute SP_InsertModelo @Modelo", new { m.Modelo });
                    return Convert.ToInt32(id);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void InsertFornecedor(Fornecedores forn)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    Connection().Execute(@"Insert Into Fornecedores Values(@Fornecedor, @Telefone, @WhatsApp, @Email)", 
                        new { forn.Fornecedor, forn.Telefone, forn.WhatsApp, forn.Email });
                    
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void InsertCliente(Clientes cli)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    Connection().Execute(@"Insert Into Clientes Values(@Nome, @Sexo, @Cpf, @Email, @Telefone, @WhatsApp)",
                        new { cli.Nome, cli.Sexo, cli.Cpf, cli.Email, cli.Telefone, cli.WhatsApp });

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void InsertVendedor(Vendedores v)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    Connection().Execute(@"Insert Into Vendedores Values(@Nome, @Email, @Telefone, @WhatsApp, @Sexo)",
                        new { v.Nome, v.Email, v.Telefone, v.WhatsApp, v.Sexo });

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int InsertVenda(Vendas v)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    var id = Connection().ExecuteScalar(@"Execute SP_InsertVenda @Id_Cliente, @Id_Vendedor, @DataVenda, @TipoComprovante,
                                            @NumeroComprovante, @Total, @TotalPago, @TipoVenda",
                        new { v.Id_Cliente, v.Id_Vendedor, v.DataVenda, v.TipoComprovante,
                            v.NumeroComprovante, v.Total, v.TotalPago, v.TipoVenda });
                    return Convert.ToInt32(id);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int InsertPagamento(Pagamentos p)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    var idPag =Connection().ExecuteScalar(@"Execute SP_InsertPagamento @DataPag, @TipoPag, @Valor, @Categoria",
                        new
                        {
                            p.DataPag,
                            p.TipoPag,
                            p.Valor,
                            p.Categoria
                        });
                    return Convert.ToInt32(idPag);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void InsertVenda_Pagamento(int idPag, int idVenda)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    Connection().Execute(@"Insert Into Vendas_Pagamentos Values(@idVenda, @idPag)",
                        new { idVenda, idPag });

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void InsertProduto_Venda(Produtos_Venda pv)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    Connection().Execute(@"Insert Into Produtos_Vendas Values(@Id_Venda, @Id_Produto, @ValorVenda, @Quantidade, @SubTotal)",
                        new { pv.Id_Venda, pv.Id_Produto, pv.ValorVenda, pv.Quantidade, pv.SubTotal });

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        ///////////// Updates ////////////////
        public int UpdateProdutoEstoqueCompra(Produtos p)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    var id = Connection().Execute(@"Update Produtos Set ValorCompra = @ValorCompra , Estoque = @Estoque , Estado = @Estado Where IdProduto = @IdProduto",
                        new { p.IdProduto, p.ValorCompra, p.Estoque, p.Estado });
                    return Convert.ToInt32(id);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int UpdateProdutoEstoqueVenda(Produtos_Venda pv)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    var id = Connection().Execute(@"Update Produtos Set Estoque = (Select Estoque from Produtos Where IdProduto = @Id_Produto) - @Quantidade Where IdProduto = @Id_Produto",
                        new { pv.Id_Produto, pv.Quantidade });
                    return Convert.ToInt32(id);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int UpdateProduto(Produtos p)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    var id = Connection().Execute(@"Update Produtos Set Id_Categoria = @Id_Categoria, Id_Tipo = @Id_Tipo, Id_Marca = @Id_Marca, Id_Modelo = @Id_Modelo, Produto = @Produto , Descricao = @Descricao, ValorVenda = @ValorVenda , Estado = @Estado, EstoqueMin = @EstoqueMin Where IdProduto = @IdProduto",
                        new { p.IdProduto, p.Id_Categoria, p.Id_Tipo, p.Id_Marca, p.Id_Modelo, p.Produto, p.Descricao, p.Estado, p.ValorVenda, p.EstoqueMin });
                    return Convert.ToInt32(id);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void UpdateFornecedor(Fornecedores forn)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    Connection().Execute(@"Update Fornecedores Set Fornecedor=@Fornecedor, Telefone=@Telefone, WhatsApp=@WhatsApp, Email=@Email Where IdFornecedor=@IdFornecedor",
                        new { forn.Fornecedor, forn.Telefone, forn.WhatsApp, forn.Email, forn.IdFornecedor });

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void UpdateCliente(Clientes cli)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    Connection().Execute(@"Update Clientes Set Nome=@Nome, Sexo=@Sexo, Cpf=@Cpf, Email=@Email, Telefone=@Telefone, WhatsApp=@WhatsApp Where IdCliente=@IdCliente",
                        new { cli.Nome, cli.Sexo, cli.Cpf, cli.Email, cli.Telefone, cli.WhatsApp, cli.IdCliente });

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void UpdateVendedor(Vendedores v)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                    Connection().Execute(@"Update Vendedores Set Nome=@Nome, Email=@Email, Telefone=@Telefone, WhatsApp=@WhatsApp, Sexo=@Sexo Where IdVendedor=@IdVendedor",
                        new { v.Nome, v.Email, v.Telefone, v.WhatsApp, v.Sexo, v.IdVendedor });

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        ////////////////////////// Deletes ////////////////////////
        public void DeleteProduto(int idProd)
        {
            try
            {
                using (Connection())
                {
                    Connection().Open();
                     Connection().Execute(@"Delete Produtos Where IdProduto = @idProd", new { idProd });
                    
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

    }
}
