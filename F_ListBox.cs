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
    public partial class F_ListBox : Form
    {
        protected void atualizar(ListBox lb,List<string>l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }

        List<string> carros = new List<string>();

        public F_ListBox()
        {
            InitializeComponent();
            carros.Add("Golf");
            carros.Add("Sonata");
            carros.Add("Elanttra");

            //associando a lista carros ao ListBox atraves do DataSource(é uma propriedade do lisbox e combobox que permite associar o elemento a uma 
            //fonte de dados, que pode ser um bando de dados ou uma lista que nem nesse caso)
            lib_carro.DataSource = carros;
        }

        private void btn_adc_Click(object sender, EventArgs e)
        {
            if (tb_adcCarro.Text == string.Empty)
            {
                MessageBox.Show("Digite um carro");
                tb_adcCarro.Focus();
            }
            else
            {
                carros.Add(tb_adcCarro.Text);

                //apos adicionar o carro na lista, precisa apagar a lisbox e associar novamente a lista "carros"
                //lib_carro.DataSource = null;
                //lib_carro.DataSource = carros;
                atualizar(lib_carro,carros);
                tb_adcCarro.Clear();
                tb_adcCarro.Focus();
            }
        }

        private void btn_rmover_Click(object sender, EventArgs e)
        {
            if (lib_carro.Text == string.Empty)
            {
                MessageBox.Show("Não há o que remover");
            }
            else
            {
                //removendo o item da lista carros com o indice selecionado da listbox pois são o mesmo...(RemoveAt, remove o indice indicado)
                carros.RemoveAt(lib_carro.SelectedIndex);
                atualizar(lib_carro, carros);
            }
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            //obtendo o carro da lista carros a partir do indice selecionado na ListBox
            tb_carroObtido.Text = carros[lib_carro.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            atualizar(lib_carro, carros);
        }
    }
}
