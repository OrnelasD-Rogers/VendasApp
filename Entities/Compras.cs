using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Compras
    {
        public int IdCompra { get; set; }
        public int Id_Fornecedor { get; set; }
        public DateTime DataCompra { get; set; }
        public string Compra { get; set; }
        public double ValorTotal { get; set; }
        public double ValorFrete { get; set; }
        public string NotaFiscal { get; set; }
        public string Fornecedor { get; set; }



        public bool ValidaCompra(DateTimePicker dtpDataCompra, TextBox tbDescComp, TextBox tbValorTotal,
            TextBox tbValorFrete, TextBox tbNotaFiscal, ErrorProvider ep)
        {
            List<bool> erroList = new List<bool>();

            erroList.Add(VDescComp(this.Compra, tbDescComp, ep));
            erroList.Add(VData(this.DataCompra, dtpDataCompra, ep));
            erroList.Add(VVal(this.ValorTotal, tbValorTotal, ep));
            erroList.Add(VVal(this.ValorTotal, tbValorFrete, ep));
            erroList.Add(VNotaFisc(this.NotaFiscal, tbNotaFiscal, ep));

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

        public bool VData(DateTime dataCompra, DateTimePicker dtpDataCompra, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            if (dataCompra == null)
            {
                ep.SetError(dtpDataCompra, "Selecione a data da compra");
                errosList.Add(false);
            }
            if (Invalida(errosList))
            {
                ep.SetError(dtpDataCompra, "");
            }
            return Invalida(errosList);
        }

        private bool VDescComp(string desc, TextBox tbDescComp, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            if (desc == string.Empty)
            {
                ep.SetError(tbDescComp, "Defina uma descrição para a compra");
                errosList.Add(false);
            }
            if (Invalida(errosList))
            {
                ep.SetError(tbDescComp, "");
            }
            return Invalida(errosList);
        }

        private bool VVal(double valUn, TextBox tbVal, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            if (valUn == 0.0)
            {
                ep.SetError(tbVal, "Digite o valor");
                errosList.Add(false);
            }
            if (Invalida(errosList))
            {
                ep.SetError(tbVal, "");
            }
            return Invalida(errosList);
        }

        private bool VNotaFisc(string notaFisc, TextBox tbNotaFisc, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            if (notaFisc == string.Empty)
            {
                ep.SetError(tbNotaFisc, "Entre com a Nota Fiscal");
                errosList.Add(false);
            }
            if (notaFisc.Any(char.IsLetter))
            {
                ep.SetError(tbNotaFisc, "Uma nota fiscal deve conter apenas números");
                errosList.Add(false);
            }
            if (Invalida(errosList))
            {
                ep.SetError(tbNotaFisc, "");
            }
            return Invalida(errosList);
        }
    }
}
