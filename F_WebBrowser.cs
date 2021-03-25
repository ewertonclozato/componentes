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
    public partial class F_WebBrowser : Form
    {
        public F_WebBrowser()
        {
            InitializeComponent();
        }
        private void navegar(string endereco)
        {
            if (tb_url.Text != string.Empty)
            {
                if (tb_url.Text.Contains("http") || tb_url.Text.Contains(".com") || tb_url.Text.Contains(".br"))
                {
                    webBrowser1.Navigate(endereco);
                }
                else
                {
                    webBrowser1.Navigate("http://google.com/search?q=" + endereco);
                }
            }
            else
            {
                MessageBox.Show("Digite uma url");
                tb_url.Focus();
            }
        }
        
        
        private void pb_ir_Click(object sender, EventArgs e)
        {
            navegar(tb_url.Text);
        }

        private void tb_url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                navegar(tb_url.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void F_WebBrowser_Load(object sender, EventArgs e)
        {
            tb_url.Focus();
            voltar();
            frente();
            webBrowser1.GoHome();
        }
        private void frente()
        {
            bool frente = webBrowser1.CanGoForward;
            if (frente == true)
            {
                pb_refazer.Image = Properties.Resources.refazer;
                pb_refazer.Enabled = webBrowser1.CanGoForward;
            }
            else
            {
                pb_refazer.Image = Properties.Resources.refazerOPA;
            }
        }

        private void voltar()
        {
            bool voltar = webBrowser1.CanGoBack;
            if (voltar == true)
            {
                pb_desfazer.Image = Properties.Resources.desfazer;
                pb_desfazer.Enabled = webBrowser1.CanGoBack;
            }
            else
            {
                pb_desfazer.Image = Properties.Resources.desfazerOPA;
            }
        }
        

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            voltar();
            frente();
            tb_url.Text = webBrowser1.Url.ToString();
        }

        private void pb_home_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void pb_desfazer_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void pb_refazer_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            pb_refazer.Enabled = webBrowser1.CanGoForward;
        }

        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            pb_refazer.Enabled = webBrowser1.CanGoBack;
        }

        private void pb_parar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void pb_recarregar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void pb_pesquisar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://google.com/search?q=" + tb_url.Text);
        }

        private void webBrowser1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void webBrowser1_ControlRemoved(object sender, ControlEventArgs e)
        {
            
        }

        private void tb_url_MouseClick(object sender, MouseEventArgs e)
        {
            tb_url.Select();
        }
    }
}
