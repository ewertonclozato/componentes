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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }
        //https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.maskedtextbox.mask?view=netcore-3.1

        private void cb_mostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrarSenha.Checked)
            {
                mtb_senha.PasswordChar = '\0'; //\0 significa null para char
            }
            else
            {
                mtb_senha.PasswordChar = '•';
            }
        }

        private void btn_mostrarCpf_Click(object sender, EventArgs e)
        {
            //alterando a propriedade de como a mask sera mostrada
            mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (mtb_cpf.MaskFull == false)
            {
                MessageBox.Show("Não há CPF para exibir");
            }
            else
            {
                MessageBox.Show(mtb_cpf.Text);
            }
        }
    }
}
