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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text); //mostrando elemento selecionado do CB
        }

        private void btn_limparElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
            cb_transportes.ResetText();// apaga o que esta selecionado em cb_transportes
            tb_transporte.Clear();
            tb_transporte.Focus();
        }

        private void btn_resetarElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
            cb_transportes.Items.Add("Carro");
            cb_transportes.Items.Add("Moto");
            cb_transportes.Items.Add("Avião");
            cb_transportes.Items.Add("Navio");
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transporte.Text = cb_transportes.Text; //adicionando o valor selecionado em "cb_transportes" e colocando em tb_transporte
            //pelo metodo: cb_transportes_SelectedIndexChanged
        }

        private void btn_adcElemento_Click(object sender, EventArgs e)
        {
            if (tb_transporte.Text == string.Empty)
            {
                MessageBox.Show("Digite um transporte para ser adicionado a lista");
                tb_transporte.Focus();
            }
            else
            {
                if (cb_transportes.FindString(tb_transporte.Text) < 0)
                {
                    MessageBox.Show("O transporte \"" + tb_transporte.Text + "\" foi adcionado.");
                    cb_transportes.Items.Add(tb_transporte.Text);
                    tb_transporte.Clear();
                    tb_transporte.Focus();
                }
                else
                {
                    MessageBox.Show("Esse transporte ja esta na lista");
                }
                
            }
        }

        private void F_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_transporte.Text != string.Empty)
            {
                
                if (cb_transportes.FindString(tb_transporte.Text) < 0)
                {
                    MessageBox.Show("O transporte \"" + tb_transporte.Text + "\" foi adcionado.");
                    e.SuppressKeyPress = true;
                    e.Handled = false;
                    cb_transportes.Items.Add(tb_transporte.Text);
                    tb_transporte.Clear();
                    tb_transporte.Focus();
                }
                else
                {
                    MessageBox.Show("Esse transporte ja esta na lista");
                }
            }
            else if (e.KeyCode == Keys.Enter && tb_transporte.Text == string.Empty)
            {
                MessageBox.Show("Digite um transporte para ser adicionado a lista");
                tb_transporte.Focus();
            }
        }

        private void btn_deletarTransporte_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Remove(cb_transportes.SelectedItem);//remove o item selecionado do CB
            tb_transporte.Clear();
        }
    }
}
