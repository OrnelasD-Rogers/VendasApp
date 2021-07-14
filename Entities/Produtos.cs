using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Produtos
    {
        public int IdProduto { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_Tipo { get; set; }
        public int Id_Marca { get; set; }
        public int Id_Modelo { get; set; }
        public string Produto { get; set; }
        public string Descricao { get; set; }
        public double ValorCompra { get; set; }
        public double ValorVenda { get; set; }
        public int Estoque { get; set; }
        public int EstoqueMin { get; set; }
        public bool Estado { get; set; }

    }
}
