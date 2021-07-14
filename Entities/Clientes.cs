using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Clientes
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string WhatsApp { get; set; }

        public bool ValidaCliente(TextBox tbNome, TextBox tbEmail, MaskedTextBox mtbCpf, MaskedTextBox mtbTelefone, MaskedTextBox mtbWhats, ErrorProvider ep)
        {
            List<bool> erroList = new List<bool>();
            erroList.Add(VNome(this.Nome, tbNome, ep));
            erroList.Add(VEmail(this.Email, tbEmail, ep));
            erroList.Add(VCpf(this.Cpf, mtbCpf, ep));
            erroList.Add(VTelefone(this.Telefone, mtbTelefone, ep));
            erroList.Add(VWhats(this.WhatsApp, mtbWhats, ep));

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

        private bool VTelefone(string numero, MaskedTextBox mtbTelefone, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            if (numero.Length == 0)
            {
                ep.SetError(mtbTelefone, "Digite um Numero para o Cliente");
                errosList.Add(false);                
            }
            if (numero.Length > 0 && numero.Length < 10)
            {
                ep.SetError(mtbTelefone, "Um Numero de telefone deve ter 10 ou mais digitos");
                errosList.Add(false);                
            }
            if (Invalida(errosList))
            {
                ep.SetError(mtbTelefone, "");
            }
            return Invalida(errosList);
        }

        private bool VWhats(string numero, MaskedTextBox mtbTelefone, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            if (numero.Length > 0 && numero.Length < 11)
            {
                ep.SetError(mtbTelefone, "Um Numero para Whatsapp deve ter 8 digitos + DDD");
                errosList.Add(false);                
            }
            if (Invalida(errosList))
            {
                ep.SetError(mtbTelefone, "");
            }
            return Invalida(errosList);
        }

        private bool VNome(string texto, TextBox tbNome, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();            
            Regex regex = new Regex(@"[^A-z\s\d][\\\^]?");

            if (texto == string.Empty)
            {                           
                ep.SetError(tbNome, "Digite o nome do Cliente");
                errosList.Add(false);
            }
            if (regex.IsMatch(texto))
            {                
                ep.SetError(tbNome, "O nome do Cliente não deve possuir numeros ou Caractéres especiais");                           
                errosList.Add(false);
            }
            if (texto.Trim().Length > 0 && texto.Trim().Length < 10)
            {
                ep.SetError(tbNome, "Digite o Nome e o Sobrenome do cliente");                           
                errosList.Add(false);
            }
            if (Invalida(errosList))
            {
                ep.SetError(tbNome, "");
            }
            return Invalida(errosList);
        }

        private bool VEmail(string email, TextBox tbEmail, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            Regex regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

            if (email.Length > 0 && !regex.IsMatch(email))
            {
                ep.SetError(tbEmail, "Digite um Email Válido");                
                errosList.Add(false);
            }
            if (Invalida(errosList))
            {
                ep.SetError(tbEmail, "");
            }
            return Invalida(errosList);
        }

        private bool VCpf(string cpf, MaskedTextBox mtbCpf, ErrorProvider ep)
        {
            List<bool> errosList = new List<bool>();
            Regex regex = new Regex(@"(?!(\d)\1{2}.\1{3}.\1{3}-\1{2})\d{3}\.\d{3}\.\d{3}\-\d{2}");

            if (cpf.Replace(" ", "").Replace(".", "").Replace("-", "").Length > 0)
            {
                //Cpf deve estar no modelo 999.999.999-30 para ser aceito como válido
                if (!regex.IsMatch(cpf))
                {
                    ep.SetError(mtbCpf, "Cpf Inválido");                    
                    errosList.Add(false);
                }
                if (Invalida(errosList))
                {
                    ep.SetError(mtbCpf, "");
                }
                return Invalida(errosList);
            }
            else
                return true;
        }

    }
}
