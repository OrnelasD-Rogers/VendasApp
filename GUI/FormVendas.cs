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
    public partial class FormVendas : Form
    {
        List<VW_Vendas> vendasList = new List<VW_Vendas>();
        List<VW_Vendas> preFilterList = new List<VW_Vendas>();
        VW_Vendas Venda = new VW_Vendas();

        public FormVendas()
        {
            InitializeComponent();
            Inicializacao();
        }

        private void Inicializacao()
        {
            backgroundWorker1.RunWorkerAsync();
            dgVendas.AutoGenerateColumns = false;
            LimpaCamposVenda();            

        }
        private void CarregaGrid(List<VW_Vendas> vendasList)
        {
            dgVendas.DataSource = vendasList;
            dgVendas.Update();
            dgVendas.Refresh();
        }
        private void LimpaCamposVenda()
        {
            tbDataVenda.Clear();
            tbCliente.Clear();
            tbTipoComp.Clear();
            tbComprovante.Clear();
            tbTipoVenda.Clear();
            tbVendedor.Clear();
            tbValorTotal.Clear();
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

        private void AlterarBtnFiltro()
        {
            //Se o icone for um filtro, ele vira uma lata de lixo e aplica o filtro
            if (btnFiltrar.IconChar == IconChar.Filter)
            {
                preFilterList = (List<VW_Vendas>)dgVendas.DataSource;
                btnFiltrar.IconChar = IconChar.TrashAlt;
            }
            //Se o icone for uma lata de lixo, ele vira um filtro
            else if (btnFiltrar.IconChar == IconChar.TrashAlt)
            {               
                btnFiltrar.IconChar = IconChar.Filter;
                //Atribui a lista que existia antes do filtro ser aplicado                
                CarregaGrid(preFilterList);
                InicializaFiltro();
            }
        }

        private void InicializaFiltro()
        {
            //Limpa os textos das combo boxes
            {

                cbTipoFiltro.Text = null;
                cbTipoVenda.Text = null;
            }
            lblInicio.Hide();
            lblFinal.Hide();
            tbValFiltroIni.Hide();
            tbValFiltroFin.Hide();
            dtpDataIni.Hide();
            dtpDataFin.Hide();
            cbTipoVenda.Hide();
            btnFiltrar.Location = new Point((cbTipoFiltro.Location.X + cbTipoFiltro.Width + 10), cbTipoFiltro.Location.Y);
        }

        //Posiciona os campos pra filtro de acordo com o filtro escolhido
        private void PosicionaFiltro(ComboBox filtro)
        {
            int x = 0;
            switch (filtro.Text)
            {
                case "Data":
                    //Esconde os campos de valor
                    {
                        tbValFiltroIni.Hide();
                        tbValFiltroFin.Hide();
                        cbTipoVenda.Hide();
                    }

                    //Posiciona os Campos
                    {
                        //Define a localização da primeira label e atribui seu texto
                        lblInicio.Text = "De: ";
                        x = cbTipoFiltro.Location.X + cbTipoFiltro.Width + 10;
                        lblInicio.Location = new Point(x, cbTipoFiltro.Location.Y);

                        //Define a localização do dateTimePicker Inicial
                        x = lblInicio.Location.X + lblInicio.Width + 5;
                        dtpDataIni.Location = new Point(x, cbTipoFiltro.Location.Y);

                        //Define a localização da segunda label e atribui seu texto
                        lblFinal.Text = "Até: ";
                        x = dtpDataIni.Location.X + dtpDataIni.Width + 10;
                        lblFinal.Location = new Point(x, cbTipoFiltro.Location.Y);

                        //Define a localização do dateTimePicker Final
                        x = lblFinal.Location.X + lblFinal.Width + 5;
                        dtpDataFin.Location = new Point(x, cbTipoFiltro.Location.Y);

                        //Define a localização do btnFiltrar
                        x = dtpDataFin.Location.X + dtpDataFin.Width + 10;
                        btnFiltrar.Location = new Point(x, cbTipoFiltro.Location.Y);
                    }

                    //Mostra os campos da data e as labels
                    {
                        lblInicio.Show();
                        dtpDataIni.Show();
                        lblFinal.Show();
                        dtpDataFin.Show();
                    }

                    break;
                case "Valor da Venda":
                    //Esconde os campos de data
                    {
                        dtpDataIni.Hide();
                        dtpDataFin.Hide();
                        cbTipoVenda.Hide();
                    }

                    //Posiciona os Campos
                    {
                        //Define a localização da primeira label e atribui seu texto
                        lblInicio.Text = "De: ";
                        x = cbTipoFiltro.Location.X + cbTipoFiltro.Width + 10;
                        lblInicio.Location = new Point(x, cbTipoFiltro.Location.Y);

                        //Define a localização da TextBox tbValFiltroIni 
                        x = lblInicio.Location.X + lblInicio.Width + 5;
                        tbValFiltroIni.Text = "R$ ";
                        tbValFiltroIni.Location = new Point(x, cbTipoFiltro.Location.Y);

                        //Define a localização da segunda label e atribui seu texto
                        lblFinal.Text = "Até: ";
                        x = tbValFiltroIni.Location.X + tbValFiltroIni.Width + 10;
                        lblFinal.Location = new Point(x, cbTipoFiltro.Location.Y);

                        //Define a localização da TextBox tbValFiltroFin 
                        x = lblFinal.Location.X + lblFinal.Width + 5;
                        tbValFiltroFin.Text = "R$ ";
                        tbValFiltroFin.Location = new Point(x, cbTipoFiltro.Location.Y);

                        //Define a localização do btnFiltrar
                        x = tbValFiltroFin.Location.X + tbValFiltroFin.Width + 10;
                        btnFiltrar.Location = new Point(x, cbTipoFiltro.Location.Y);
                    }

                    //Mostra os campos da data e as labels
                    {
                        lblInicio.Show();
                        tbValFiltroIni.Show();
                        lblFinal.Show();
                        tbValFiltroFin.Show();
                    }

                    break;
                case "Tipo Venda":
                    //Esconde os outros Campos
                    {
                        lblInicio.Hide();
                        lblFinal.Hide();
                        dtpDataIni.Hide();
                        dtpDataFin.Hide();
                        tbValFiltroIni.Hide();
                        tbValFiltroFin.Hide();
                    }

                    //Posiciona os Campos
                    {
                        //Define a localização da primeira label e atribui seu texto                        
                        x = cbTipoFiltro.Location.X + cbTipoFiltro.Width + 10;
                        cbTipoVenda.Location = new Point(x, cbTipoFiltro.Location.Y);

                        //Define a localização do btnFiltrar
                        x = cbTipoVenda.Location.X + cbTipoVenda.Width + 10;
                        btnFiltrar.Location = new Point(x, cbTipoFiltro.Location.Y);
                    }

                    //Mostra os campos da data e as labels
                    {
                        cbTipoVenda.Show();
                    }

                    break;
                
            }
        }
        private void Filtrar(ComboBox filtro)
        {

            if (btnFiltrar.IconChar == IconChar.Filter)
            {
                switch (filtro.Text)
                {
                    case "Data":
                        AlterarBtnFiltro();
                        CarregaGrid(
                            ((List<VW_Vendas>)dgVendas.DataSource)
                            .Where(
                                x => x.DataVenda >= dtpDataIni.Value
                            &&
                                x.DataVenda <= dtpDataFin.Value
                            )
                            .Select(x => x).ToList()
                            );
                        

                        break;
                    case "Valor da Venda":
                        AlterarBtnFiltro();
                        CarregaGrid(
                            ((List<VW_Vendas>)dgVendas.DataSource)
                            .Where(
                                x => x.Total >= Convert.ToDouble(tbValFiltroIni.Text.Trim().Replace("R$ ", ""))
                            &&
                                x.Total <= Convert.ToDouble(tbValFiltroFin.Text.Trim().Replace("R$ ", ""))
                            )
                            .Select(x => x).ToList()
                            );
                        
                        break;
                    case "Tipo Venda":
                        switch (cbTipoVenda.Text)
                        {
                            case "Balcão":
                                AlterarBtnFiltro();
                                CarregaGrid(
                            ((List<VW_Vendas>)dgVendas.DataSource)
                            .Where(
                                x => x.TipoVenda == "Balcao")
                            .Select(x => x).ToList()
                            );
                                
                                break;

                            case "Internet":
                                AlterarBtnFiltro();
                                CarregaGrid(
                            ((List<VW_Vendas>)dgVendas.DataSource)
                            .Where(
                                x => x.TipoVenda == "Internet")
                            .Select(x => x).ToList()
                            );
                                
                                break;

                            case "Telefone":
                                AlterarBtnFiltro();
                                CarregaGrid(
                            ((List<VW_Vendas>)dgVendas.DataSource)
                            .Where(
                                x => x.TipoVenda == "Telefone")
                            .Select(x => x).ToList()
                            );
                                
                                break;

                            case "WhatsApp":
                                AlterarBtnFiltro();
                                CarregaGrid(
                           ((List<VW_Vendas>)dgVendas.DataSource)
                           .Where(
                               x => x.TipoVenda == "WhatsApp")
                           .Select(x => x).ToList()
                           );
                                
                                break;

                            case "Serviço":
                                AlterarBtnFiltro();
                                CarregaGrid(
                           ((List<VW_Vendas>)dgVendas.DataSource)
                           .Where(
                               x => x.TipoVenda == "Serviço")
                           .Select(x => x).ToList()
                           );
                                
                                break;
                            default:
                                MessageBox.Show("Selecione um tipo para pesquisar!");
                                break;
                        }
                        break;
                } 
            }
            else
            {
                AlterarBtnFiltro();                
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            vendasList = MetodosBd.GetVendasGird();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CarregaGrid(vendasList);
        }

        private void cbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            PosicionaFiltro(cbTipoFiltro);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid(
                        ((List<VW_Vendas>)dgVendas.DataSource)
                        .Where(
                            x => x.NomeCli.ToUpper().Contains(tbPesq.Text.Trim().ToUpper())
                        ||
                            x.NomeVendedor.ToUpper().Contains(tbPesq.Text.Trim().ToUpper())
                        )
                        .Select(x => x).ToList()
                        );
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar(cbTipoFiltro);
        }

        private void dgVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpaCamposVenda();
            Venda = null;
            Venda = (VW_Vendas)dgVendas.SelectedRows[0].DataBoundItem;
            tbDataVenda.Text = Venda.DataVenda.ToShortDateString();
            tbCliente.Text = Venda.NomeCli;
            tbTipoComp.Text = Venda.TipoComprovante;
            tbComprovante.Text = Venda.NumeroComprovante;
            tbTipoVenda.Text = Venda.TipoVenda;
            tbVendedor.Text = Venda.NomeVendedor;
            tbValorTotal.Text = Venda.Total.ToString("C2");

        }

        private void btnItensVenda_Click(object sender, EventArgs e)
        {
            FormListaProdutos formLista = new FormListaProdutos(Venda.IdVenda);
            formLista.Show();
        }

        private void dgVendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = string.Format("{0:C2}", (double)e.Value);
            }
        }

        private void btnVoltarPesq_Click(object sender, EventArgs e)
        {
            tbPesq.Clear();
            if (preFilterList == null)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                CarregaGrid(preFilterList);
            }
            
        }
    }
}
