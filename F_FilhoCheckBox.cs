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
    public partial class F_FilhoCheckBox : Form
    {
        public F_CheckBox f_CheckBox; //cria uma variavel com a F_CheckBox zerada
        public F_FilhoCheckBox()
        {
            InitializeComponent();
            f_CheckBox = Application.OpenForms["F_CheckBox"] as F_CheckBox; //associa na variavel "f_CheckBox" a propriedade "Application.OpenForms["F_CheckBox"]"
            //para retornar a coleção do aplicativo aberto que foi informado entre "[](o indice da coleção é o nome do formulario PAI)" e converte (as) para o formulario PAI

            cb_carro.Checked = f_CheckBox.cb_carro.Checked; //cb_carro desse formFILHO, vai receber o cheched do cb_carro do formPAI
            cb_aviao.Checked = f_CheckBox.cb_aviao.Checked;
            cb_navio.Checked = f_CheckBox.cb_navio.Checked;
            cb_moto.Checked = f_CheckBox.cb_moto.Checked;
        }

        private void F_FilhoCheckBox_FormClosed(object sender, FormClosedEventArgs e)
        {   //ao contrario, cheched do cb_carro do formPAI vai receber o cheched do cb_carro desse formFILHO (AO FECHAR A JANELA)
            f_CheckBox.cb_carro.Checked = cb_carro.Checked;
            f_CheckBox.cb_aviao.Checked = cb_aviao.Checked;
            f_CheckBox.cb_navio.Checked = cb_navio.Checked;
            f_CheckBox.cb_moto.Checked = cb_moto.Checked;
        }
            //ao contrario, cheched do cb_carro do formPAI vai receber o cheched do cb_carro desse formFILHO (NO MOMENTO EM QUE É TROCADO NO FILHO)
            private void cb_carro_CheckedChanged(object sender, EventArgs e)
            {
                f_CheckBox.cb_carro.Checked = cb_carro.Checked;
            }
        
            private void cb_aviao_CheckedChanged(object sender, EventArgs e)
            {
                f_CheckBox.cb_aviao.Checked = cb_aviao.Checked;
            }

            private void cb_navio_CheckedChanged(object sender, EventArgs e)
            {
                f_CheckBox.cb_navio.Checked = cb_navio.Checked;
            }

            private void cb_moto_CheckedChanged(object sender, EventArgs e)
            {
                f_CheckBox.cb_moto.Checked = cb_moto.Checked;
            }
    }
}

