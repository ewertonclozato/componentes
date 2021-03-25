using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//fazendo import de thred de time
using System.Threading;

namespace Componentes
{
    public partial class F_progressbar : Form
    {
        public F_progressbar()
        {
            InitializeComponent();
        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {
            try {
                    //definindo o valor do progressbar pelo textbox
                    if (int.Parse(tb_valor.Text) >= progressBar_valor.Minimum & int.Parse(tb_valor.Text) <= progressBar_valor.Maximum)
                    {
                        progressBar_valor.Value = int.Parse(tb_valor.Text);
                    }
                    else
                    {
                        MessageBox.Show("Valor ERRADO!");
                    }
                }
            catch
            {
                MessageBox.Show("Por favor informar um numero inteiro");
            }
        }
        private void lb_valorI_TextChanged(object sender, EventArgs e)
        {
            lb_valorI.Text = lb_valorI.Text;
        }

        private void btn_preencher_Click(object sender, EventArgs e)
        {
            progressBar_valor.Value = 0;
            progressBar_valor.Maximum = int.Parse(tb_contagem.Text);
            int i = 0;

            while(i<=progressBar_valor.Maximum)
            {
                lb_valorI.Text = "Valor de i: " + i.ToString();
                progressBar_valor.Value = i;
                i++;
                //usando o metedo sleep do thred em milisegundos
                //Thread.Sleep(200);
            }
        }

        private void F_progressbar_Load(object sender, EventArgs e)
        {

        }

        
    }
}
