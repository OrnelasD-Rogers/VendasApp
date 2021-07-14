using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAcess;

namespace Business
{
    public static class MetodosBd
    {

        public static List<Fornecedores> GetFornecedores()
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetFornecedores();
        }

        public static List<Compras> GetCompras()
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetCompras();
        }

        public static int InsertCompra(Compras compra)
        {
            AcessoBd bd = new AcessoBd();
            return bd.InsertCompra(compra);
        }

        public static void InsertCompra_Produto(Compras_Produtos cp)
        {
            AcessoBd bd = new AcessoBd();
            Produtos produto = bd.GetEstoqueProdutoById(cp.Id_Produto).FirstOrDefault();
            bd.InsertCompra_Produto(cp);
            bd.UpdateProdutoEstoqueCompra(new Produtos
            {
                IdProduto = cp.Id_Produto,
                ValorCompra = cp.ValorUnidade,
                Estoque = produto.Estoque + cp.Quantidade,
                Estado = cp.OfertaAtiva
            });
        }

        public static List<Compras_Produtos> GetProdutosCompra(int idCompra)
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetProdutosCompra(idCompra);
        }

        public static List<VW_ProdutosString> GetProdutosString()
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetProdutosString();
        }

        public static List<VW_ProdutoGrid> GetProdutosView()
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetProdutosView();
        }

        public static void UpdateProduto(Produtos p)
        {
            AcessoBd bd = new AcessoBd();
            bd.UpdateProduto(p);
        }

        public static List<Categorias> GetCategorias()
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetCategorias();
        }

        public static List<Tipos> GetTipos()
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetTipos();
        }
        public static List<Marcas> GetMarcas()
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetMarcas();
        }
        public static List<Modelos> GetModelos()
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetModelos();
        }

        public static void InsertProduto(Produtos p)
        {
            AcessoBd bd = new AcessoBd();
            bd.InsertProduto(p);
        }

        public static int InsertCategoria(Categorias c)
        {
            AcessoBd bd = new AcessoBd();
            return bd.InsertCategoria(c);
        }

        public static int InsertTipo(Tipos t)
        {
            AcessoBd bd = new AcessoBd();
            return bd.InsertTipo(t);
        }

        public static int InsertMarca(Marcas m)
        {
            AcessoBd bd = new AcessoBd();
            return bd.InsertMarca(m);
        }
        public static int InsertModelo(Modelos m)
        {
            AcessoBd bd = new AcessoBd();
            return bd.InsertModelo(m);
        }

        public static void DeleteProduto(int idProd)
        {
            AcessoBd bd = new AcessoBd();
            bd.DeleteProduto(idProd);
        }

        public static void InsertFornecedor(Fornecedores fornecedor)
        {
            AcessoBd bd = new AcessoBd();
            bd.InsertFornecedor(fornecedor);
        }

        public static void UpdateFornecedor(Fornecedores fornecedor)
        {
            AcessoBd bd = new AcessoBd();
            bd.UpdateFornecedor(fornecedor);
        }

        public static List<Clientes> GetClientes()
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetClientes();
        }

        public static void InsertCliente(Clientes cliente)
        {
            if (cliente.Cpf != string.Empty)
            {
                cliente.Cpf = cliente.Cpf.Replace(".", "").Replace("-", "");
            }
            AcessoBd bd = new AcessoBd();
            bd.InsertCliente(cliente);
        }

        public static void UpdateCliente(Clientes cliente)
        {
            if (cliente.Cpf != string.Empty)
            {
                cliente.Cpf = cliente.Cpf.Replace(".", "").Replace("-", "");
            }
            AcessoBd bd = new AcessoBd();
            bd.UpdateCliente(cliente);
        }

        public static List<VW_Vendas> GetVendasGird()
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetVendasGrid();
        }

        public static List<VW_ProdutosVenda> GetProdutosVendaById(int idVenda)
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetProdutosVenda(idVenda);
        }
        public static List<Vendedores> GetVendedores()
        {
            AcessoBd bd = new AcessoBd();
            return bd.GetVendedores();
        }

        public static void InsertVendedor(Vendedores vendedor)
        {
            AcessoBd bd = new AcessoBd();
            bd.InsertVendedor(vendedor);
        }

        public static void UpdateVendedor(Vendedores vendedor)
        {
            AcessoBd bd = new AcessoBd();
            bd.UpdateVendedor(vendedor);
        }
    }
}
