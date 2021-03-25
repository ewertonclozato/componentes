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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            if (clb_listaTransportes.Items.Count == 0)
            {
                MessageBox.Show("Não há transporte na lista");
            }
            else
            {
                /*
                txt =clb_listaTransportes.Items[0].ToString(); 
                txt vai receber o primeiro elemento de "clb_listaTransportes" mesmo se não tiver selecionado
                //é um metodo de indice, então tem que colocar o valor do indice de entrada e converter para string para poder mostrar na janela
                */

                /*
                nesse caso, txt vai receber, convertido em string, o elemento do primeiro item marcado no checkedListBox, o mesmo recebe o indice "0"
                txt = clb_listaTransportes.CheckedItems[0].ToString();
                */


                //nesse caso, usando foreach no metodo clb_listaTransportes.CheckedItems e listando todos os itens marcados
                foreach (string t in clb_listaTransportes.CheckedItems)
                {
                    txt += t + System.Environment.NewLine.ToString();
                }
                if (txt == string.Empty)
                {
                    MessageBox.Show("Marque pelo menos um transporte da lista");
                }
                else
                {
                    MessageBox.Show("Marcados: \n" + txt);
                }
            }
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_listaTransportes.Items.Clear();//limpando a lista
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            /*
            object carro = "Carro"; //instaciando carro em object, mas poderia ser uma variavel ou tbm direto dentro do metodo
            clb_listaTransportes.Items.Add(carro,false);
            */
            clb_listaTransportes.Items.Clear();//limpar a lista antes de resetar, pq se nao vai concatenar
            clb_listaTransportes.Items.Add("Carro", false);
            clb_listaTransportes.Items.Add("Avião", false);
            clb_listaTransportes.Items.Add("Moto", false);
            clb_listaTransportes.Items.Add("Navio", false);

            // clb_listaTransportes.Items.AddRange(); esse metodo adiciona uma coleção, gerada por uma lista
        }

        private void btn_adcTransporte_Click(object sender, EventArgs e)
        {
            if (tb_adctransporte.Text != string.Empty)
            {
                clb_listaTransportes.Items.Add(tb_adctransporte.Text);
                tb_adctransporte.Clear();
                tb_adctransporte.Focus();
            }
            else
            {
                MessageBox.Show("Digite um transporte para ser adicionado a lista");
                tb_adctransporte.Focus();
            }
        }

        private void F_CheckedListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_adctransporte.Text != string.Empty)
            {
                clb_listaTransportes.Items.Add(tb_adctransporte.Text);
                tb_adctransporte.Clear();
                tb_adctransporte.Focus();
                e.SuppressKeyPress = true;

            }
            else if (e.KeyCode == Keys.Enter && tb_adctransporte.Text == string.Empty)
            {
                MessageBox.Show("Digite um transporte para ser adicionado a lista");
                tb_adctransporte.Focus();
            }
        }
    }
}
