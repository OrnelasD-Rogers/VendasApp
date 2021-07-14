using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Pagamentos
    {
        public int IdPagamento { get; set; }
        public DateTime DataPag { get; set; }
        public string TipoPag { get; set; }
        public double Valor { get; set; }
        public int Parcelas { get; set; }
        public string Categoria { get; set; }

        public bool ValidaPag(ComboBox cbTipoPag, ErrorProvider ep)
        {
            List<bool> erroList = new List<bool>();
            erroList.Add(VTipoPag(this.TipoPag, cbTipoPag, ep));        
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

        private bool VTipoPag(string tipoPag, ComboBox cbTipoPag, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            if (tipoPag == string.Empty || cbTipoPag.Text == string.Empty)
            {
                ep.SetError(cbTipoPag, "Selecione o Tipo de Pagamento");
                errosList.Add(false);                
            }
            if (Invalida(errosList))
            {
                ep.SetError(cbTipoPag, "");
            }
            return Invalida(errosList);
        }
    }
}
