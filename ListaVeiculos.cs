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
    public partial class ListaVeiculos : Form
    {
        F_Principal f_Principal; // declarando uma variavel do tipo "F_Principal" para receber tudo de F_Principal
        //(não vai servir para o que ja tem la, e sim para retornar algo novo)

        public ListaVeiculos(string valor, F_Principal f) //declarando "F_Principal f" vou poder usar de alterar qualquer propriedade e variavel
            //nesse metodo
        {
            InitializeComponent();
            tb_listaVeiculos.Text = valor;
            f_Principal = f; //atribuindo a "f_Principal" (que é a classe pra ser usada no GERAL) f para usar os parametor de entrada
            f.num = 10;
            
        }
        public ListaVeiculos()
        {
            InitializeComponent();
        }

        private void ListaVeiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            f_Principal.tb_listaVeiculos.Text = tb_listaVeiculos.Text; //atrubuindo as string's desse TB ao TB de F_Principal
        }
    }
}
