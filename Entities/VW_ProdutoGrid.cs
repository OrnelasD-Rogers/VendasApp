using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class VW_ProdutoGrid
    {
        public int IdProduto { get; set; }
        public string Produto { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descricao { get; set; }
        public double ValorCompra { get; set; }
        public double ValorVenda { get; set; }
        public int Estoque { get; set; }
        public int EstoqueMin { get; set; }
        public bool Estado { get; set; }
    }
}
