using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class VW_ProdutosVenda
    {
        public int IdProduto_Venda { get; set; }
        public int Id_Produto { get; set; }
        public int Id_Venda { get; set; }
        public string Produto { get; set; }
        public double ValorVenda { get; set; }
        public int Quantidade { get; set; }
        public double SubTotal { get; set; }
       
    }
}
