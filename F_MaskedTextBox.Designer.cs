namespace Componentes
{
    partial class F_MaskedTextBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_senha = new System.Windows.Forms.Label();
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.cb_mostrarSenha = new System.Windows.Forms.CheckBox();
            this.btn_mostrarCpf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(12, 90);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(38, 13);
            this.lb_senha.TabIndex = 0;
            this.lb_senha.Text = "Senha";
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(15, 106);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '•';
            this.mtb_senha.Size = new System.Drawing.Size(225, 20);
            this.mtb_senha.TabIndex = 1;
            this.mtb_senha.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(15, 25);
            this.mtb_cpf.Mask = "000.000.000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(225, 20);
            this.mtb_cpf.TabIndex = 2;
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Location = new System.Drawing.Point(12, 9);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(27, 13);
            this.lb_cpf.TabIndex = 3;
            this.lb_cpf.Text = "CPF";
            // 
            // cb_mostrarSenha
            // 
            this.cb_mostrarSenha.AutoSize = true;
            this.cb_mostrarSenha.Location = new System.Drawing.Point(15, 132);
            this.cb_mostrarSenha.Name = "cb_mostrarSenha";
            this.cb_mostrarSenha.Size = new System.Drawing.Size(95, 17);
            this.cb_mostrarSenha.TabIndex = 4;
            this.cb_mostrarSenha.Text = "Mostrar Senha";
            this.cb_mostrarSenha.UseVisualStyleBackColor = true;
            this.cb_mostrarSenha.CheckedChanged += new System.EventHandler(this.cb_mostrarSenha_CheckedChanged);
            // 
            // btn_mostrarCpf
            // 
            this.btn_mostrarCpf.Location = new System.Drawing.Point(15, 51);
            this.btn_mostrarCpf.Name = "btn_mostrarCpf";
            this.btn_mostrarCpf.Size = new System.Drawing.Size(225, 36);
            this.btn_mostrarCpf.TabIndex = 5;
            this.btn_mostrarCpf.Text = "Mostrar CPF";
            this.btn_mostrarCpf.UseVisualStyleBackColor = true;
            this.btn_mostrarCpf.Click += new System.EventHandler(this.btn_mostrarCpf_Click);
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 170);
            this.Controls.Add(this.btn_mostrarCpf);
            this.Controls.Add(this.cb_mostrarSenha);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.mtb_senha);
            this.Controls.Add(this.lb_senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_MaskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masked Text Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.MaskedTextBox mtb_senha;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.CheckBox cb_mostrarSenha;
        private System.Windows.Forms.Button btn_mostrarCpf;
    }
}