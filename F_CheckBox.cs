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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();//criando lista de checkbox
            

        public F_CheckBox()
        {
            InitializeComponent();
            transp.Add(cb_carro);
            transp.Add(cb_aviao);
            transp.Add(cb_navio);
            transp.Add(cb_moto);
        }

        private void btn_transportesMarcados_Click(object sender, EventArgs e)
        {
            string txt= "";
                foreach (CheckBox t in transp)
                {
                    if (t.Checked)
                    {
                        txt += t.Text + System.Environment.NewLine.ToString();
                    }
                }
                if (txt==string.Empty)
                    {
                        MessageBox.Show("Marque pelo menos um transporte");
                    }
                    else
                    {
                        MessageBox.Show("Marcados: \n"+txt);
                    }
                        /*
                        if (cb_carro.Checked)//Checked é um bool, se tiver marcado é true se nao, é false.
                        {
                            txt += cb_carro.Text + System.Environment.NewLine.ToString();//concatenando txt + o checkbox se for true
                        }
                        if (cb_aviao.Checked)//Checked é um bool, se tiver marcado é true se nao, é false.
                        {
                            txt += cb_aviao.Text + System.Environment.NewLine.ToString();//concatenando txt + o checkbox se for true
                        }
                        if (cb_navio.Checked)//Checked é um bool, se tiver marcado é true se nao, é false.
                        {
                            txt += cb_navio.Text + System.Environment.NewLine.ToString();//concatenando txt + o checkbox se for true
                        }
                        if (cb_moto.Checked)//Checked é um bool, se tiver marcado é true se nao, é false.
                        {
                            txt += cb_moto.Text + System.Environment.NewLine.ToString();//concatenando txt + o checkbox se for true
                        }
                        */
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e) //evento CheckedChanged do proprio CheckBox
        {
            if (cb_patinete.Checked)
            {
                MessageBox.Show(cb_patinete.Text + " marcado(a)");
            }
            else //if (cb_patinete.Checked == false)
            {
                MessageBox.Show(cb_patinete.Text + " foi desmarcado(a)");
            }
        }

        private void btn_abrirFilho_Click(object sender, EventArgs e)
        {
            F_FilhoCheckBox f_FilhoCheckBox = new F_FilhoCheckBox();//instaciando um objeto do tipo "F_FilhoCheckBox" para abrir a janela
            f_FilhoCheckBox.ShowDialog();//abrindo a janela
        }
    }
}
