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
    public partial class F_Timer : Form
    {

        int num = 1;
        int px, py;

        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            //num = 0;
            px = pictureBox1.Location.X;
            py = pictureBox1.Location.Y;
        }

        private void btn_iniciar_t1_Click(object sender, EventArgs e)
        {
            //timer1.Interval = 1500;
            timer1.Start();
        }

        private void btn_parar_t1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num <= 15)
            {
                label1.Text = num.ToString();
                num++;
            }
            else
            {
                timer1.Stop();
            }
            
        }

        private void btn_reiniciar_t1_Click(object sender, EventArgs e)
        {
            num = 1;
            timer1.Start();
        }

        private void btn_iniciar_carro_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btn_parar_carro_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = pictureBox1.Location.X.ToString();

            if (px < 400)
            {
                px -= 25;
                pictureBox1.Location = new Point(px, py);
                px = pictureBox1.Location.X;
            }
            else if(px < 550)
            {
                px -= 10;
                pictureBox1.Location = new Point(px, py);
                px = pictureBox1.Location.X;
            }
            else
            {
                px--;
                pictureBox1.Location = new Point(px, py);
                px = pictureBox1.Location.X;
            }
            if (px < 12)
            {
                timer2.Stop();
            }
        }
    }
}
