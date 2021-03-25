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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            //dividino os links de ll_multiplosLinks
            //(começo(lembrando que começa em 0), tamanhbo da palavra, url do link)

            ll_multiploLinks.Links.Add(0, 6, "http://google.com.br");
            ll_multiploLinks.Links.Add(9, 11, "calc.exe");
            ll_multiploLinks.Links.Add(23, 7, "http://youtube.com");

            //desabilitando a calculadora que esta na posição 1
            //ll_multiploLinks.Links[1].Enabled = false;
        }

        private void ll_youtube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start (inicia o processo de link, tem que passar como string)
            System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query="+tb_busca.Text);

            //apos clicado, defini como link visitado
            //ll_youtube.LinkVisited = true;

            LinkLabel linkLabel = (LinkLabel)sender;
            linkLabel.LinkVisited = true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void F_LinkLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_busca.Text != string.Empty)
            {
                e.SuppressKeyPress = true; //tira o som do beep quando "ENTER" for apertado
                System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=" + tb_busca.Text);
                tb_busca.Clear();
            }
        }

        //nesse caso o parametro "e" vai receber as configurações do contrutor que foi de dividir os links
        private void ll_multiploLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                                          //(area_do_link_clicada.pegar_o_link.link_da_area_clicada.conerter_para_string)
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
