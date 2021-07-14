using Business;
using Entities;
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

namespace GUI
{
    public partial class FormVendedores : Form
    {
        Vendedores Vendedor = new Vendedores();
        List<Vendedores> VendedoresList = new List<Vendedores>();
        public FormVendedores()
        {
            InitializeComponent();
            Inicializacao();
        }
        private void Inicializacao()
        {
            backgroundWorker1.RunWorkerAsync();
            LimpaCamposVendedor();
            AlteraBtnCadCliente(true);
            btnLimparVendedor.Show();
            gbCliente.Hide();
            gbBotoes.Show();
            mtbTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtbWhatsApp.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void LimpaCamposVendedor()
        {
            tbVendedor.Clear();
            tbEmail.Clear();
            mtbTelefone.Clear();
            mtbWhatsApp.Clear();
            cbSexo.Text = null;
            errorProvider1.Clear();
        }

        private void AlteraBtnCadCliente(bool onOff)
        {
            if (onOff == true)
            {
                btnAddVendedor.Text = "Cadastrar Vendedor";
                btnAddVendedor.IconChar = IconChar.UserPlus;
            }
            if (onOff == false)
            {
                btnAddVendedor.Text = "Salvar Alterações";
                btnAddVendedor.IconChar = IconChar.Save;
            }
        }

        private void CarregaGrid(List<Vendedores> vendedoresList)
        {
            dgClientes.AutoGenerateColumns = false;
            dgClientes.DataSource = vendedoresList;
            dgClientes.Update();
            dgClientes.Refresh();
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

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            gbCliente.Location = gbBotoes.Location;
            gbBotoes.Hide();
            gbCliente.Show();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            //Pega a Linha selecionada no datagrid, a transforma em objeto e a coloca nas textBox
            if (dgClientes.Rows.Count > 0)
            {
                if (dgClientes.SelectedRows[0] != null)
                {
                    Vendedor = null;
                    Vendedor = (Vendedores)dgClientes.SelectedRows[0].DataBoundItem;
                    tbVendedor.Text = Vendedor.Nome;
                    tbEmail.Text = Vendedor.Email;
                    mtbTelefone.Text = Vendedor.Telefone;
                    mtbWhatsApp.Text = Vendedor.WhatsApp;
                    cbSexo.SelectedIndex = (Vendedor.Sexo == 'M' ? 0 : 1);

                    gbCliente.Location = gbBotoes.Location;
                    gbBotoes.Hide();
                    AlteraBtnCadCliente(false);
                    btnLimparVendedor.Hide();
                    gbCliente.Show();
                    MascaraMaskedTextBoxes(mtbTelefone);
                    MascaraMaskedTextBoxes(mtbWhatsApp);
                }
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            switch (btnAddVendedor.Text)
            {
                case "Salvar Alterações":
                    try
                    {
                        Vendedores vendedores = new Vendedores()
                        {
                            IdVendedor = Vendedor.IdVendedor,
                            Nome = tbVendedor.Text.Trim(),
                            Email = tbEmail.Text.Trim(),
                            Sexo = (cbSexo.Text == "Masculino" ? 'M' : 'F'),
                            Telefone = mtbTelefone.Text.Trim(),
                            WhatsApp = mtbWhatsApp.Text.Trim()
                        };

                        if (vendedores.ValidaVendedor(tbVendedor, tbEmail, mtbTelefone, mtbWhatsApp, errorProvider1))
                        {
                            MetodosBd.UpdateVendedor(vendedores);
                            MessageBox.Show("Alterações Salvas!");
                            Inicializacao(); 
                        }


                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Não foi possivel Salvar as Alterações. " + erro.Message);
                    }
                    break;
                case "Cadastrar Vendedor":
                    try
                    {
                        Vendedores vendedores = new Vendedores()
                        {
                            Nome = tbVendedor.Text.Trim(),
                            Email = tbEmail.Text.Trim(),
                            Sexo = (cbSexo.Text == "Masculino" ? 'M' : 'F'),
                            Telefone = mtbTelefone.Text.Trim(),
                            WhatsApp = mtbWhatsApp.Text.Trim()
                        };
                        if (vendedores.ValidaVendedor(tbVendedor, tbEmail, mtbTelefone, mtbWhatsApp, errorProvider1))
                        {
                            MetodosBd.InsertVendedor(vendedores);
                            MessageBox.Show("Vendedor Cadastrado!");
                            Inicializacao();
                        }
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Não foi possivel Cadastrar o Vendedor. " + erro.Message);
                    }
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicializacao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbPesq.Text.All(char.IsDigit) && tbPesq.Text.Length > 0)
            {
                if (tbPesq.Text.Trim().Length >= 8)
                {
                    CarregaGrid(
                        ((List<Vendedores>)dgClientes.DataSource).Where(x => x.Telefone.Contains(tbPesq.Text)
                        ||
                        x.WhatsApp.Contains(tbPesq.Text.Trim()))
                        .Select(x => x).ToList()
                        );
                }
                else
                {
                    CarregaGrid(
                        ((List<Vendedores>)dgClientes.DataSource).Where(x => x.IdVendedor == Convert.ToInt32(tbPesq.Text.Trim()))
                        .Select(x => x).ToList()
                        );
                }
            }
            if (tbPesq.Text.Trim().Contains("@"))
            {
                CarregaGrid(
                        ((List<Vendedores>)dgClientes.DataSource).Where(x => x.Email.ToUpper().Contains(tbPesq.Text.Trim().ToUpper()))
                        .Select(x => x).ToList()
                        );
            }
            if (tbPesq.Text.Trim().Replace(" ", "").All(char.IsLetter))
            {
                CarregaGrid(
                        ((List<Vendedores>)dgClientes.DataSource).Where(x => x.Nome.ToUpper().Contains(tbPesq.Text.ToUpper()))
                        .Select(x => x).ToList()
                        );
            }
        }

        private void btnVoltarPesq_Click(object sender, EventArgs e)
        {
            tbPesq.Clear();
            CarregaGrid(VendedoresList);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            VendedoresList = MetodosBd.GetVendedores();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CarregaGrid(VendedoresList);
        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            LimpaCamposVendedor();
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
                if (e.Value.ToString().Length == 11)
                {
                    e.Value = String.Format("{0:(##) #####-####}", Convert.ToInt64(e.Value));
                }
                if (e.Value.ToString().Length == 10)
                {
                    e.Value = String.Format("{0:(##) ####-####}", Convert.ToInt64(e.Value));
                }
            }
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                if (e.Value.ToString().Length == 11)
                {
                    e.Value = String.Format("{0:(##) #####-####}", Convert.ToInt64(e.Value));
                }
            }
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
