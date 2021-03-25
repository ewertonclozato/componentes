using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Principal : Form
    {
        List<string> veiculos = new List<string>();
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            veiculos.Add("Golf");
            tb_listaVeiculos.Text = veiculos[0].ToString();
            num = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            //veiculos.Clear();

            if (tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um veículo"); //mensagem de erro caso a TB esteja vazia
                tb_veiculo.Focus();// metodo para focar o cursor na TB
            }
            else
            {
                veiculos.Add(tb_veiculo.Text);
            }

            tb_listaVeiculos.Text += System.Environment.NewLine.ToString() + veiculos[veiculos.Count - 1];
                
                //tb_listaVeiculos.Text += tb_veiculo.Text + System.Environment.NewLine.ToString();
                //"System.Environment.NewLine.ToString()" quebra de linha no textBox

                //tb_veiculo.Clear();
                //tb_veiculo.Focus();
            

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_mostrarLista_Click(object sender, EventArgs e) //botao para chamar janela e mostrar a lista de veiculos adc.
        {
            if (tb_listaVeiculos.Text != string.Empty) //string.Empty (caso o campo nao tenha nanhum texto ou TXT)
            {
                ListaVeiculos listaVeiculos = new ListaVeiculos(tb_listaVeiculos.Text,this); //declarando um novo objeto para ser chamado. "this" você declara a classe para o metodo
                listaVeiculos.ShowDialog(); //ShowDialog ele é modal, só pode voltar para a janela anterior caso essa seja fechada antes.
            }
            else
            {
                MessageBox.Show("Lista vazia");
            }
            
        }

        private void btn_listaDictionary_Click(object sender, EventArgs e)
        {
            string valores = "";
            foreach (string valor in veiculos)
            {
                valores += valor + "\n";
            }

            if (veiculos.Count >= 0)
            {
                MessageBox.Show(valores);
                /*foreach (string v in veiculos)
                {
                    MessageBox.Show(v);
                }*/
                
            }
            else
            {
                MessageBox.Show("A lista esta vazia");
            }
        }

        private void F_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_veiculo.Text != "")
            {
                tb_listaVeiculos.Text += tb_veiculo.Text + System.Environment.NewLine.ToString();
                tb_veiculo.Clear();
                tb_veiculo.Focus();
                e.SuppressKeyPress = true; //tira o som do beep quando "ENTER" for apertado

            }else if (e.KeyCode == Keys.Enter && tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um veículo");
                tb_veiculo.Focus();
            }
        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor de num: "+num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();//instanciando um novo objeto de "F_CheckBox" para ser chamado pelo evento "checkBoxToolStripMenuItem_Click"
            f_CheckBox.ShowDialog();//motrando a janela do novo "F_CheckBox" que foi instanciado
        }

        private void checkdListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();// instanciando um novo objeto de "F_CheckedListBox" para ser chamado pelo evento "checkdListBoxToolStripMenuItem_Click"
            f_CheckedListBox.ShowDialog();//motrando a janela do novo "F_CheckedListBox" que foi instanciado
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }

        private void maskedTextBoxMáscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
            f_MaskedTextBox.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar f_MonthCalendar = new F_MonthCalendar();
            f_MonthCalendar.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //definindo as atividades de nitifyicon
            if (e.ClickedItem.Name.ToString() == "Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "Fechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "Mensagem")
            {
                MessageBox.Show("Componentes");
            }   
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown f_NumericUpDown = new F_NumericUpDown();
            f_NumericUpDown.ShowDialog();
        }

        private void pictureBoxEArquivoDeRecursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox_e_Arquivo_de_recursos f_PictureBox_E_Arquivo_De_Recursos = new F_PictureBox_e_Arquivo_de_recursos();
            f_PictureBox_E_Arquivo_De_Recursos.ShowDialog();
        }

        private void progressbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_progressbar f_Progressbar = new F_progressbar();
            f_Progressbar.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Radiobutton f_Radiobutton = new F_Radiobutton();
            f_Radiobutton.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            F_TrackBar f_TrackBar = new F_TrackBar();
            f_TrackBar.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            F_TreeView f_TreeView = new F_TreeView();
            f_TreeView.ShowDialog();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_WebBrowser f_WebBrowser = new F_WebBrowser();
            f_WebBrowser.ShowDialog();
        }

        private void splitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_SplitContainer f_SplitContainer = new F_SplitContainer();
            f_SplitContainer.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            F_TabControl f_TabControl = new F_TabControl();
            f_TabControl.ShowDialog();
        }

        private void tableLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TableLayoutPanel f_TableLayoutPanel = new F_TableLayoutPanel();
            f_TableLayoutPanel.ShowDialog();
        }

        private void toolStripContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ToolStripContainer f_ToolStripContainer = new F_ToolStripContainer();
            f_ToolStripContainer.ShowDialog();
        }

        private void backgroundworkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Backgroundworker f_Backgroundworker = new F_Backgroundworker();
            f_Backgroundworker.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            F_Timer f_Timer = new F_Timer();
            f_Timer.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            F_SQLite f_SQLite = new F_SQLite();
            f_SQLite.ShowDialog();
        }
    }
}
