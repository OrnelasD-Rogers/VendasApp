using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Compras_Produtos
    {
        public int Id_Compra { get; set; }
        public int Id_Produto { get; set; }
        public double ValorUnidade { get; set; }
        public int Quantidade { get; set; }
        public double SubTotal { get; set; }
        public string Produto { get; set; }
        public bool OfertaAtiva { get; set; }

        public bool ValidaProduto(ComboBox cbProduto, TextBox tbQtd, TextBox tbValUn,  ErrorProvider ep)
        {
            List<bool> erroList = new List<bool>();
            erroList.Add(VProduto(this.Produto, cbProduto, ep));
            erroList.Add(VQtd(this.Quantidade, tbQtd, ep));
            erroList.Add(VValUn(this.ValorUnidade, tbValUn, ep));           

            return Invalida(erroList);
        }

        private bool Invalida(List<bool> errosList)
        {
            bool val = true;
            foreach (bool item in errosList)
            {
                if (item == false)
                {
                    val = item;
                }
            }
            return val;
        }

        public bool VProduto(string produto, ComboBox cbProduto, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            if (produto == null || produto == "")
            {
                ep.SetError(cbProduto, "Selecione um Produto");
                errosList.Add(false);
            }            
            if (Invalida(errosList))
            {
                ep.SetError(cbProduto, "");
            }
            return Invalida(errosList);
        }

        private bool VQtd(int qtd, TextBox tbQuantidade, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            if (qtd == 0)
            {
                ep.SetError(tbQuantidade, "Digite a Quantidade");
                errosList.Add(false);
            }
            if (Invalida(errosList))
            {
                ep.SetError(tbQuantidade, "");
            }
            return Invalida(errosList);
        }

        private bool VValUn(double valUn, TextBox tbValUn, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();

            if (valUn == 0.0)
            {
                ep.SetError(tbValUn, "Digite o valor por Unidade");
                errosList.Add(false);
            }
            if (Invalida(errosList))
            {
                ep.SetError(tbValUn, "");
            }
            return Invalida(errosList);
        }

    }
}
