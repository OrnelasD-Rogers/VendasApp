using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class VW_Vendas
    {
        public int IdVenda { get; set; }
        public int IdVendedor { get; set; }
        public int IdCliente { get; set; }
        public string NomeCli { get; set; }
        public string NomeVendedor { get; set; }
        public DateTime DataVenda { get; set; }
        public string TipoComprovante { get; set; }
        public string NumeroComprovante { get; set; }
        public double Total { get; set; }
        public string TipoVenda { get; set; }
    }
}
