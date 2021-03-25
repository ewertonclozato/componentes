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
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void btn_obterData_Click(object sender, EventArgs e)
        {
            tb_dataCompleta.Text = dtp_data.Text;//obten a string completa de dtp_data

            tb_dia.Text = dtp_data.Value.Day.ToString(); //obtem somente o dia, é retornado um int, por isso precisa ser convertido em string
            tb_mes.Text = dtp_data.Value.Month.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_setarData_Click(object sender, EventArgs e)
        {   
            //convertendo dia, mes e ano, para a data
            DateTime dateTime = new DateTime(int.Parse(tb_ano.Text), int.Parse(tb_mes.Text), int.Parse(tb_dia.Text));

            if (dateTime>DateTime.Today)
            {
                MessageBox.Show("Essa data ainda não chegou");
            }
            else
            {
                //passando os valores convertidos como data para o valor de dpt_data.Value
                dtp_data.Value = dateTime;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_dataCompleta.Clear();
            tb_ano.Clear();
            tb_dia.Clear();
            tb_mes.Clear();
        }
    }
}
