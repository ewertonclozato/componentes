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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
        }

        private void F_TabControl_Load(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        WebBrowser novoWebBrowser = new WebBrowser();

        private void btn_novaTeb_Click(object sender, EventArgs e)
        {
            if (tb_novaABA.Text == string.Empty)
            {
                TabPage aba = new TabPage(tb_novaABA.Text);
                tabControl1.TabPages.Add(aba);

                //WebBrowser novoWebBrowser = new WebBrowser();
                aba.Controls.Add(novoWebBrowser);

                novoWebBrowser.GoHome();
                aba.Text = webBrowser1.DocumentTitle;
               
                aba.TabIndex = tabControl1.TabPages.Count;
                novoWebBrowser.Dock = DockStyle.Fill;

                novoWebBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(DocumentCompleted);


            }
        }
        private void DocumentCompleted(object sender, WebBrowserProgressChangedEventArgs e)
        {
            tabControl1.SelectedTab.Text = novoWebBrowser.DocumentTitle;
        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tab_home.Text = webBrowser1.DocumentTitle;
        }

        
        private void F_TabControl_VisibleChanged(object sender, EventArgs e)
        {
        }
    }
}
