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
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
        }
        public void obterData()
        {
            tb_dataHoje.Text = mc_calendario.TodayDate.ToShortDateString();

            //int dia = mc_calendario.SelectionStart.Day;
            //int mes = mc_calendario.SelectionStart.Month;
            //int ano = mc_calendario.SelectionStart.Year;

            tb_dataInicial.Text = mc_calendario.SelectionStart.ToShortDateString();


            tb_dataFinal.Text = mc_calendario.SelectionEnd.ToShortDateString();
        }

        private void btn_pegarData_Click(object sender, EventArgs e)
        {
            obterData();
        }

        private void mc_calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            obterData();
        }

        private void mc_calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            obterData();
        }

        private void tb_dataInicial_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
