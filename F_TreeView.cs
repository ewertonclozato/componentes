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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tb_selecionado.Text = treeView1.SelectedNode.Text;
        }

        private void btn_adcEstado_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Estados")
            {
                if (tb_estado.Text == string.Empty)
                {
                    MessageBox.Show("Digite o nome de um estado para adicionar");
                }
                else
                {
                    TreeNode estados = treeView1.SelectedNode.Nodes.Add(tb_estado.Text);
                    tb_estado.Clear();
                    tb_estado.Focus();
                }
            }
            else
            {
                MessageBox.Show("Não é um estado");
            }
            
        }

        private void btn_removerEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode.Parent.Text == "Estados")
                    treeView1.SelectedNode.Remove();
            }
            catch
            {
                MessageBox.Show("Selecione um estado para remover");
            }
        }

        private void btn_adcCidade_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode.Parent.Text == "Estados")
                {
                    if (tb_cidade.Text == string.Empty)
                    {
                        MessageBox.Show("Digite uma cidade");
                        tb_cidade.Focus();
                    }
                    else
                    {
                        TreeNode cidades = treeView1.SelectedNode.Nodes.Add(tb_cidade.Text);
                        tb_cidade.Clear();
                        tb_cidade.Focus();
                    }
                }
                else if (treeView1.SelectedNode.Parent.Parent.Text == "Estados")
                {
                    MessageBox.Show("Selecione um estado para adicionar uma cidade");
                }
            }
            catch
            {
                if (treeView1.SelectedNode.Nodes.Count == 0)
                {
                    MessageBox.Show("Não ha estado para adicionar cidade");
                }
                else
                {
                    MessageBox.Show("Selecione um estado para adicionar uma cidade");
                }
            }
            
        }

        private void btn_removerCidade_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Level == 2)
            {
                if(treeView1.SelectedNode.Parent.Parent.Text == "Estados")
                {
                    treeView1.SelectedNode.Remove();
                }
                else
                {
                    MessageBox.Show("Selecione uma cidade para remover");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma cidade para remover");
            }
        }
    }
}
