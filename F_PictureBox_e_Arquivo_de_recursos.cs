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
    public partial class F_PictureBox_e_Arquivo_de_recursos : Form
    {
        public F_PictureBox_e_Arquivo_de_recursos()
        {
            InitializeComponent();
        }

        private void F_PictureBox_e_Arquivo_de_recursos_Load(object sender, EventArgs e)
        {
            //definindo a string de label 1 e 2 no load do form.
            //Arquivo de recursos serve para você poder alterar algum elemento de uma vez só em todo lugar que ele apareça no programa, sem precisar
            //alterar um por um.

            lb_meuNome.Text = Properties.Resources.meuNome;
            lb_nomeCurso.Text = Properties.Resources.nomeCurso;

            pb_tri.Image = Properties.Resources.TRI2;
        }

        private void btn_mudarImagem_Click(object sender, EventArgs e)
        {
            pb_tri.Image = Properties.Resources.TRI;
        }
    }
}
