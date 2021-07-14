using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Vendas
    {
        public int IdVenda { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Vendedor { get; set; }
        public DateTime DataVenda { get; set; }
        public string TipoComprovante { get; set; }
        public string NumeroComprovante { get; set; }
        public double Total { get; set; }
        public double TotalPago { get; set; }
        public string TipoVenda { get; set; }

        public bool ValidaVenda(DateTimePicker dtpDataVenda, ComboBox cbVendedor, ComboBox cbTipoComp,TextBox tbNumCom, ComboBox cbTipoVenda, ErrorProvider ep)
        {
            List<bool> erroList = new List<bool>();
            erroList.Add(VDataVenda(this.DataVenda, dtpDataVenda, ep));
            erroList.Add(VVendedor(this.Id_Vendedor, cbVendedor, ep));
            erroList.Add(VTipoCompNumCom(this.TipoComprovante,this.NumeroComprovante, cbTipoComp, tbNumCom, ep));
            erroList.Add(VTipoVenda(this.TipoVenda, cbTipoVenda, ep));

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

        private bool VDataVenda(DateTime data, DateTimePicker dtpDataVenda, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();

            if (data < DateTime.Now.AddDays(-8))
            {
                ep.SetError(dtpDataVenda, $"Uma venda precisa ter a data superior a {DateTime.Now.AddDays(-8).ToShortDateString()}");
                errosList.Add(false);
            }
            if (data == null)
            {
                ep.SetError(dtpDataVenda, "Entre com uma data Válida");
                errosList.Add(false);
            }
            if (Invalida(errosList))
            {
                ep.SetError(dtpDataVenda, "");
            }
            return Invalida(errosList);
        }

        private bool VVendedor(int idVendedor, ComboBox cbVendedor, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            if (idVendedor == 0 || cbVendedor.Text == string.Empty)
            {
                ep.SetError(cbVendedor, "Selecione o Vendedor");
                errosList.Add(false);
            }
            if (Invalida(errosList))
            {
                ep.SetError(cbVendedor, "");
            }
            return Invalida(errosList);
        }

        private bool VTipoCompNumCom(string tipoComp, string numComp, ComboBox cbTipoCom, TextBox tbComp, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            if (tipoComp != "N/A" || tipoComp == string.Empty)
            {
                if (numComp.Length == 0)
                {
                    ep.SetError(tbComp, "Digite o numero do comprovante");
                    errosList.Add(false);
                }
            }
            if (Invalida(errosList))
            {
                ep.SetError(tbComp, "");
            }
            return Invalida(errosList);
        }

        private bool VTipoVenda(string tipoVenda, ComboBox cbTipoVenda, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            if (tipoVenda == string.Empty || cbTipoVenda.Text == string.Empty)
            {
                ep.SetError(cbTipoVenda, "Selecione o Tipo de Venda");
                errosList.Add(false);
            }
            if (Invalida(errosList))
            {
                ep.SetError(cbTipoVenda, "");
            }
            return Invalida(errosList);
        }


    }
}
