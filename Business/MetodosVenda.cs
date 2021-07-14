using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAcess;

namespace Business
{
    public class MetodosVenda
    {

        public static void InsertNovaVenda(List<Produtos_Venda> produtos, Vendas venda, Pagamentos pagamento)
        {
            List<int> idPagamentos = new List<int>();
            int idVenda =InsertVenda(venda);            
            idPagamentos = InsertPagamento(pagamento);
            InsertVenda_Pagamento(idPagamentos, idVenda);
            InsertProduto_Venda(produtos, idVenda);
            UpdateProdutoEstoqueVenda(produtos);

        }

        private static void InsertVenda_Pagamento(List<int> idPagamentos, int idVenda)
        {
            AcessoBd bd = new AcessoBd();
            foreach (int idPag in idPagamentos)
            {               
                bd.InsertVenda_Pagamento(idPag, idVenda);
            }
            
        }

        private static void InsertProduto_Venda(List<Produtos_Venda> produtos, int idVenda)
        {
            AcessoBd bd = new AcessoBd();
            foreach (Produtos_Venda pv in produtos)
            {
                pv.Id_Venda = idVenda;
                bd.InsertProduto_Venda(pv);
            }
            
        }

        private static List<int> InsertPagamento(Pagamentos pagamento)
        {
            List<int> idPagamentos = new List<int>();
            if (pagamento.Parcelas > 1 && pagamento.TipoPag == "Credito")
            {
                DateTime dataIni = pagamento.DataPag;
                pagamento.Valor = pagamento.Valor / pagamento.Parcelas;
                for (int i = 0; i < pagamento.Parcelas; i++)
                {
                    pagamento.DataPag = dataIni.AddMonths(i);                    
                    idPagamentos.Add(InsertPagamentos(pagamento));
                }
            }
            else
            {
                idPagamentos.Add(InsertPagamentos(pagamento));
            }
            return idPagamentos;
        }

        private static int InsertVenda(Vendas venda)
        {
            AcessoBd bd = new AcessoBd();
            return bd.InsertVenda(venda);
        }

        private static int InsertPagamentos(Pagamentos pagamento)
        {
            AcessoBd bd = new AcessoBd();
            return bd.InsertPagamento(pagamento);
        }

        private static void UpdateProdutoEstoqueVenda(List<Produtos_Venda> produtos_Venda)
        {
            AcessoBd bd = new AcessoBd();
            foreach (Produtos_Venda pv in produtos_Venda)
            {
                bd.UpdateProdutoEstoqueVenda(pv);
            }            
        }
    }
}
