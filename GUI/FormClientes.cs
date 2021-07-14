using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Business;

namespace GUI
{
    public partial class FormClientes : Form
    {
        Clientes Cli = new Clientes();
        List<Clientes> ClientesList = new List<Clientes>();
        public FormClientes()
        {
            InitializeComponent();
            Inicializacao();
        }
        private void Inicializacao()
        {
            backgroundWorker1.RunWorkerAsync();
            LimpaCamposCliente();
            AlteraBtnCadCliente(true);
            btnLimparCliente.Show();
            gbCliente.Hide();
            gbBotoes.Show();
            mtbCpf.Mask = "###,###,###-##";
            mtbTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtbWhatsApp.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }
        private void CarregaGrid(List<Clientes> Clientes)
        {
            dgClientes.DataSource = Clientes;
            dgClientes.Update();
            dgClientes.Refresh();
        }

        private void AlteraBtnCadCliente(bool onOff)
        {
            if (onOff == true)
            {
                btnAddCliente.Text = "Cadastrar Cliente";
                btnAddCliente.IconChar = IconChar.UserPlus;
            }
            if (onOff == false)
            {
                btnAddCliente.Text = "Salvar Alterações";
                btnAddCliente.IconChar = IconChar.Save;
            }
        }

        private void MascaraMaskedTextBoxes(MaskedTextBox textBox)
        {
            textBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (textBox.Text.Length == 0)
            {
                textBox.Mask = "";
            }
            if (textBox.Text.Length == 10)
            {
                textBox.Mask = "(##) ####-####";
            }
            if (textBox.Text.Length == 11)
            {
                textBox.Mask = "(##) #####-####";
            }
        }

        private void LimpaCamposCliente()
        {
            errorProvider1.Clear();
            tbCliente.Clear();
            tbEmail.Clear();
            mtbTelefone.Clear();
            mtbWhatsApp.Clear();
            mtbCpf.Clear();
            cbSexo.Text = null;
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            gbCliente.Location = gbBotoes.Location;
            gbBotoes.Hide();
            gbCliente.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ClientesList = MetodosBd.GetClientes();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CarregaGrid(ClientesList);
        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            LimpaCamposCliente();
            errorProvider1.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicializacao();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            //Pega a Linha selecionada no datagrid, a transforma em objeto e a coloca nas textBox
            if (dgClientes.Rows.Count > 0)
            {
                if (dgClientes.SelectedRows[0] != null)
                {
                    Cli = null;
                    Cli = (Clientes)dgClientes.SelectedRows[0].DataBoundItem;
                    tbCliente.Text = Cli.Nome;
                    tbEmail.Text = Cli.Email;
                    mtbCpf.Text = Cli.Cpf;
                    mtbTelefone.Text = Cli.Telefone;
                    mtbWhatsApp.Text = Cli.WhatsApp;
                    cbSexo.SelectedIndex = (Cli.Sexo == 'M' ? 0 : 1);

                    gbCliente.Location = gbBotoes.Location;
                    gbBotoes.Hide();
                    AlteraBtnCadCliente(false);
                    btnLimparCliente.Hide();
                    gbCliente.Show();
                    MascaraMaskedTextBoxes(mtbTelefone);
                    MascaraMaskedTextBoxes(mtbWhatsApp);
                }
            }
        }

        private void dgClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (Convert.ToChar(e.Value) == 'M')
                {
                    e.Value = "Masculino";
                }
                else
                {
                    e.Value = "Feminino";
                }
            }
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.Value =(Convert.ToInt64(e.Value)).ToString(@"000\.000\.000-00");

            }
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                if (e.Value.ToString().Length == 11)
                {
                    e.Value = String.Format("{0:(##) #####-####}", Convert.ToInt64(e.Value));
                }
                if (e.Value.ToString().Length == 10)
                {
                    e.Value = String.Format("{0:(##) ####-####}", Convert.ToInt64(e.Value));
                }
            }
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                if (e.Value.ToString().Length == 11)
                {
                    e.Value = String.Format("{0:(##) #####-####}", Convert.ToInt64(e.Value));
                }
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            switch (btnAddCliente.Text)
            {
                case "Salvar Alterações":
                    try
                    {
                        Clientes cliente = new Clientes()
                        {
                            IdCliente = Cli.IdCliente,
                            Nome = tbCliente.Text.Trim(),
                            Email = tbEmail.Text.Trim(),
                            Cpf = mtbCpf.Text.Trim(),
                            Sexo = (cbSexo.Text == "Masculino" ? 'M' : 'F'),
                            Telefone = mtbTelefone.Text.Trim(),
                            WhatsApp = mtbWhatsApp.Text.Trim()
                        };
                        if (cliente.ValidaCliente(tbCliente, tbEmail, mtbCpf, mtbTelefone, mtbWhatsApp, errorProvider1))
                        {
                            MetodosBd.UpdateCliente(cliente);
                            MessageBox.Show("Alterações Salvas!");
                            Inicializacao();
                        }      
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Não foi possivel Salvar as Alterações. " + erro.Message);
                    }
                    break;
                case "Cadastrar Cliente":
                    try
                    {
                        Clientes cliente = new Clientes()
                        {
                            Nome = tbCliente.Text.Trim(),
                            Email = tbEmail.Text.Trim(),
                            Cpf = mtbCpf.Text.Trim(),
                            Sexo = (cbSexo.Text == "Masculino" ? 'M' : 'F'),
                            Telefone = mtbTelefone.Text.Trim(),
                            WhatsApp = mtbWhatsApp.Text.Trim()
                        };
                        if (cliente.ValidaCliente(tbCliente, tbEmail, mtbCpf, mtbTelefone, mtbWhatsApp, errorProvider1))
                        {                            
                            MetodosBd.InsertCliente(cliente);
                            MessageBox.Show("Cliente Cadastrado!");
                            Inicializacao();
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Não foi possivel Cadastrar o Cliente. " + erro.Message);
                    }
                    break;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbPesq.Text.All(char.IsDigit) && tbPesq.Text.Length > 0)
            {
                if (tbPesq.Text.Trim().Length >= 8)
                {
                    CarregaGrid(
                        ((List<Clientes>)dgClientes.DataSource).Where(x => x.Telefone.Contains(tbPesq.Text)
                        ||
                        x.WhatsApp.Contains(tbPesq.Text.Trim()))
                        .Select(x => x).ToList()
                        );                    
                }
                else
                {
                    CarregaGrid(
                        ((List<Clientes>)dgClientes.DataSource).Where(x => x.IdCliente == Convert.ToInt32(tbPesq.Text.Trim()))                        
                        .Select(x => x).ToList()
                        );
                }
            }
            if (tbPesq.Text.Trim().Contains("@"))
            {
                CarregaGrid(
                        ((List<Clientes>)dgClientes.DataSource).Where(x => x.Email.ToUpper().Contains(tbPesq.Text.Trim().ToUpper()))
                        .Select(x => x).ToList()
                        );
            }
            if (tbPesq.Text.Trim().Replace(" ","").All(char.IsLetter))
            {
                CarregaGrid(
                        ((List<Clientes>)dgClientes.DataSource).Where(x => x.Nome.ToUpper().Contains(tbPesq.Text.ToUpper()))                        
                        .Select(x => x).ToList()
                        );
            }
        }

        private void btnVoltarPesq_Click(object sender, EventArgs e)
        {
            tbPesq.Clear();
            CarregaGrid(ClientesList);
        }

        private void mtbTelefone_Leave(object sender, EventArgs e)
        {
            MascaraMaskedTextBoxes((MaskedTextBox)sender);
        }

        private void mtbWhatsApp_Leave(object sender, EventArgs e)
        {
            MascaraMaskedTextBoxes((MaskedTextBox)sender);
        }
    }
}
