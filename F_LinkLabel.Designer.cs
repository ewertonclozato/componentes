namespace Componentes
{
    partial class F_LinkLabel
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
            this.ll_youtube = new System.Windows.Forms.LinkLabel();
            this.ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_multiploLinks = new System.Windows.Forms.LinkLabel();
            this.lb_digteBusca = new System.Windows.Forms.Label();
            this.tb_busca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ll_youtube
            // 
            this.ll_youtube.AutoSize = true;
            this.ll_youtube.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_youtube.Location = new System.Drawing.Point(29, 78);
            this.ll_youtube.Name = "ll_youtube";
            this.ll_youtube.Size = new System.Drawing.Size(85, 25);
            this.ll_youtube.TabIndex = 0;
            this.ll_youtube.TabStop = true;
            this.ll_youtube.Text = "Youtube";
            this.ll_youtube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_youtube_LinkClicked);
            // 
            // ll_calculadora
            // 
            this.ll_calculadora.AutoSize = true;
            this.ll_calculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_calculadora.Location = new System.Drawing.Point(199, 78);
            this.ll_calculadora.Name = "ll_calculadora";
            this.ll_calculadora.Size = new System.Drawing.Size(117, 25);
            this.ll_calculadora.TabIndex = 1;
            this.ll_calculadora.TabStop = true;
            this.ll_calculadora.Text = "Calculadora";
            this.ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calculadora_LinkClicked);
            // 
            // ll_multiploLinks
            // 
            this.ll_multiploLinks.AutoSize = true;
            this.ll_multiploLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_multiploLinks.Location = new System.Drawing.Point(29, 116);
            this.ll_multiploLinks.Name = "ll_multiploLinks";
            this.ll_multiploLinks.Size = new System.Drawing.Size(287, 25);
            this.ll_multiploLinks.TabIndex = 2;
            this.ll_multiploLinks.TabStop = true;
            this.ll_multiploLinks.Text = "Google - Calculadora - Youtube";
            this.ll_multiploLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_multiploLinks_LinkClicked);
            // 
            // lb_digteBusca
            // 
            this.lb_digteBusca.AutoSize = true;
            this.lb_digteBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_digteBusca.Location = new System.Drawing.Point(29, 9);
            this.lb_digteBusca.Name = "lb_digteBusca";
            this.lb_digteBusca.Size = new System.Drawing.Size(179, 26);
            this.lb_digteBusca.TabIndex = 3;
            this.lb_digteBusca.Text = "Digite sua busca:";
            // 
            // tb_busca
            // 
            this.tb_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busca.Location = new System.Drawing.Point(34, 38);
            this.tb_busca.Name = "tb_busca";
            this.tb_busca.Size = new System.Drawing.Size(286, 27);
            this.tb_busca.TabIndex = 4;
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 172);
            this.Controls.Add(this.tb_busca);
            this.Controls.Add(this.lb_digteBusca);
            this.Controls.Add(this.ll_multiploLinks);
            this.Controls.Add(this.ll_calculadora);
            this.Controls.Add(this.ll_youtube);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "F_LinkLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Link Label";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_LinkLabel_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_youtube;
        private System.Windows.Forms.LinkLabel ll_calculadora;
        private System.Windows.Forms.LinkLabel ll_multiploLinks;
        private System.Windows.Forms.Label lb_digteBusca;
        private System.Windows.Forms.TextBox tb_busca;
    }
}