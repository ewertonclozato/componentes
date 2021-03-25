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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {
            if(decimal.Parse(tb_definirValor.Text) >= nud_valor.Minimum && decimal.Parse(tb_definirValor.Text) <= nud_valor.Maximum)
            {
                //definindo o valor do numero
                nud_valor.Value = decimal.Parse(tb_definirValor.Text);
            }
            else
            {
                MessageBox.Show(tb_definirValor.Text + ". Valor não se encaixa nos parametros");
            }
        }

        private void btn_obterValor_Click(object sender, EventArgs e)
        {
            //obtendfo o valor definido
            decimal obter = nud_valor.Value;
            tb_obterValor.Text = obter.ToString();
        }
    }
}
