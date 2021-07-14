using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Entities;
using FontAwesome.Sharp;

namespace GUI
{
    public partial class FormFornecedores : Form
    {
        Fornecedores Forn = new Fornecedores();
        List<Fornecedores> FornecedoresList = new List<Fornecedores>();
        public FormFornecedores()
        {
            InitializeComponent();

            Inicializacao();

        }
        private void Inicializacao()
        {
            backgroundWorker1.RunWorkerAsync();            
            LimpaCamposFornecedor();
            AlteraBtnCadFornecedor(true);
            btnLimparFornecedor.Show();
            gbFornecedores.Hide();
            gbBotoes.Show();
            mtbTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtbWhatsApp.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

        }

        private void LimpaCamposFornecedor()
        {
            tbFornecedor.Clear();
            tbEmail.Clear();
            mtbTelefone.Clear();
            mtbWhatsApp.Clear();
            errorProvider1.Clear();
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            gbFornecedores.Location = gbBotoes.Location;
            gbBotoes.Hide();
            gbFornecedores.Show();


        }

        private void btnLimparFornecedor_Click(object sender, EventArgs e)
        {
            LimpaCamposFornecedor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicializacao();
        }

        private void AlteraBtnCadFornecedor(bool onOff)
        {
            if (onOff == true)
            {
                btnAddFornecedor.Text = "Cadastrar Fornecedor";
                btnAddFornecedor.IconChar = IconChar.UserPlus;
            }
            if (onOff == false)
            {
                btnAddFornecedor.Text = "Salvar Alterações";
                btnAddFornecedor.IconChar = IconChar.Save;
            }

        }

        private void btnEditarFornecedor_Click(object sender, EventArgs e)
        {
            //Pega a Linha selecionada no datagrid, a transforma em objeto e a coloca nas textBox
            if (dgFornecedores.SelectedRows[0] != null)
            {
                Forn = null;
                Forn = (Fornecedores)dgFornecedores.SelectedRows[0].DataBoundItem;
                tbFornecedor.Text = Forn.Fornecedor;
                tbEmail.Text = Forn.Email;
                mtbTelefone.Text = Forn.Telefone;
                mtbWhatsApp.Text = Forn.WhatsApp;

                gbFornecedores.Location = gbBotoes.Location;
                gbBotoes.Hide();
                AlteraBtnCadFornecedor(false);
                btnLimparFornecedor.Hide();
                gbFornecedores.Show();
                MascaraMaskedTextBoxes(mtbTelefone);
                MascaraMaskedTextBoxes(mtbWhatsApp);
            }

        }

        private void dgFornecedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
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
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                if (e.Value.ToString().Length == 11)
                {
                    e.Value = String.Format("{0:(##) #####-####}", Convert.ToInt64(e.Value));
                }                
            }
        }

        private void CarregaGrid(List<Fornecedores> fornecedores)
        {
            dgFornecedores.DataSource = fornecedores;
            dgFornecedores.Update();
            dgFornecedores.Refresh();
        }

        private void btnAddFornecedor_Click(object sender, EventArgs e)
        {
            switch (btnAddFornecedor.Text)
            {
                case "Salvar Alterações":
                    try
                    {
                        Fornecedores Fornecedor = new Fornecedores()
                        {
                            IdFornecedor = Forn.IdFornecedor,
                            Fornecedor = tbFornecedor.Text.Trim(),
                            Email = tbEmail.Text.Trim(),
                            Telefone = mtbTelefone.Text.Trim(),
                            WhatsApp = mtbWhatsApp.Text.Trim()
                        };

                        if (Fornecedor.ValidaFornecedor(tbFornecedor, tbEmail, mtbTelefone, mtbWhatsApp, errorProvider1))
                        {
                            MetodosBd.UpdateFornecedor(Fornecedor);
                            MessageBox.Show("Alterações Salvas!");
                            Inicializacao(); 
                        }


                    }
                    catch (Exception erro)
                    {
                        
                        MessageBox.Show("Não foi possivel Salvar as Alterações. " + erro.Message);
                    }
                    break;
                case "Cadastrar Fornecedor":
                    try
                    {
                        Fornecedores Fornecedor = new Fornecedores()
                        {
                            Fornecedor = tbFornecedor.Text.Trim(),
                            Email = tbEmail.Text.Trim(),
                            Telefone = mtbTelefone.Text,
                            WhatsApp = mtbWhatsApp.Text
                        };
                        if (Fornecedor.ValidaFornecedor(tbFornecedor, tbEmail, mtbTelefone, mtbWhatsApp, errorProvider1))
                        {
                            MetodosBd.InsertFornecedor(Fornecedor);
                            MessageBox.Show("Fornecedor Cadastrado!");
                            Inicializacao();
                        }
                        
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Não foi possivel Cadastrar o Fornecedor. " + erro.Message);
                    }
                    break;
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


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            switch (cbTipoPesq.Text)
            {
                case "Id Fornecedor":
                    CarregaGrid(
                        ((List<Fornecedores>)dgFornecedores.DataSource)
                        .Where(x => x.IdFornecedor == Convert.ToInt32(tbPesq.Text.Trim()))
                        .Select(x => x).ToList()
                        );
                    break;
                case "Fornecedor":
                    CarregaGrid(
                        ((List<Fornecedores>)dgFornecedores.DataSource)
                        .Where(x => x.Fornecedor.ToUpper().Contains(tbPesq.Text.Trim().ToUpper()))
                        .Select(x => x).ToList()
                        );
                    break;
                case "Email":
                    CarregaGrid(
                        ((List<Fornecedores>)dgFornecedores.DataSource)
                        .Where(x => x.Email.ToUpper().Contains(tbPesq.Text.Trim().ToUpper()))
                        .Select(x => x).ToList()
                        );
                    break;
                case "Telefone":
                    CarregaGrid(
                        ((List<Fornecedores>)dgFornecedores.DataSource)
                        .Where(x => x.Telefone.Contains(tbPesq.Text.Trim()))
                        .Select(x => x).ToList()
                        );
                    break;
                case "WhatsApp":
                    CarregaGrid(
                        ((List<Fornecedores>)dgFornecedores.DataSource)
                        .Where(x => x.WhatsApp.Contains(tbPesq.Text.Trim()))
                        .Select(x => x).ToList()
                        );
                    break;

                default:
                    MessageBox.Show("Selecione o tipo de pesquisa!");
                    break;
            }
        }

        private void btnVoltarPesq_Click(object sender, EventArgs e)
        {
            tbPesq.Clear();
            cbTipoPesq.Text = null;
            CarregaGrid(FornecedoresList);
        }

        private void mtbTelefone_Leave(object sender, EventArgs e)
        {
            MascaraMaskedTextBoxes((MaskedTextBox)sender);

        }

        private void mtbWhatsApp_Leave(object sender, EventArgs e)
        {
            MascaraMaskedTextBoxes((MaskedTextBox)sender);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FornecedoresList = MetodosBd.GetFornecedores();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CarregaGrid(FornecedoresList);
        }


    }
}
