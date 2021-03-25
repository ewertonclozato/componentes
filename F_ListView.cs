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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }
        protected void limpar()
        {
            tb_id.Clear();
            tb_produto.Clear();
            tb_quantidade.Clear();
            tb_preco.Clear();
            tb_id.Focus();
        }
        protected void obter()
        {
            try
            {
                tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
                tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
                tb_quantidade.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
                tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
            }
            catch
            {
                return;
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == string.Empty || tb_produto.Text == string.Empty || tb_quantidade.Text == string.Empty || tb_preco.Text == string.Empty)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
                if (tb_id.Text == string.Empty)
                {
                    tb_id.Focus();
                    return;
                }
                else if (tb_produto.Text == string.Empty)
                {
                    tb_produto.Focus();
                    return;
                }
                else if (tb_quantidade.Text == string.Empty)
                {
                    tb_quantidade.Focus();
                    return;
                }
                else if (tb_preco.Text == string.Empty)
                {
                    tb_preco.Focus();
                    return;
                }

            }
            else
            {
                //item é a linha começando pela primeira coluna e subitens são as demais colunas(a partir da segunda) pertencentes a essa linha

                //criar um novo lisviewitem, preparar os elementos do listviewitem e adicionar esse listviewitem no listview

                //criando um arrey com o numero de colunas
                string[] pr = /*new string[4]*/ { tb_id.Text, tb_produto.Text, tb_quantidade.Text, tb_preco.Text };

                //criando um novo listviewitem e adcicionando "pr" como parametro 
                ListViewItem l = new ListViewItem(pr);
                lv_produtos.Items.Add(l);
                limpar();
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
            }
            catch
            {
                MessageBox.Show("Não há nada para remover");
            }
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_quantidade.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            obter();
        }

        private void lv_produtos_DoubleClick(object sender, EventArgs e)
        {
            /*try
            {
                tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
                tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
                tb_quantidade.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
                tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
            }
            catch
            {
                return;
            }*/
        }
    }
}
