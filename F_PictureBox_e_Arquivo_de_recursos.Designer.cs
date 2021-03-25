namespace Componentes
{
    partial class F_PictureBox_e_Arquivo_de_recursos
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
            this.lb_meuNome = new System.Windows.Forms.Label();
            this.lb_nomeCurso = new System.Windows.Forms.Label();
            this.pb_tri = new System.Windows.Forms.PictureBox();
            this.btn_mudarImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tri)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_meuNome
            // 
            this.lb_meuNome.AutoSize = true;
            this.lb_meuNome.Location = new System.Drawing.Point(12, 9);
            this.lb_meuNome.Name = "lb_meuNome";
            this.lb_meuNome.Size = new System.Drawing.Size(35, 13);
            this.lb_meuNome.TabIndex = 0;
            this.lb_meuNome.Text = "label1";
            // 
            // lb_nomeCurso
            // 
            this.lb_nomeCurso.AutoSize = true;
            this.lb_nomeCurso.Location = new System.Drawing.Point(12, 22);
            this.lb_nomeCurso.Name = "lb_nomeCurso";
            this.lb_nomeCurso.Size = new System.Drawing.Size(35, 13);
            this.lb_nomeCurso.TabIndex = 1;
            this.lb_nomeCurso.Text = "label2";
            // 
            // pb_tri
            // 
            this.pb_tri.Image = global::Componentes.Properties.Resources.TRI;
            this.pb_tri.Location = new System.Drawing.Point(15, 38);
            this.pb_tri.Name = "pb_tri";
            this.pb_tri.Size = new System.Drawing.Size(250, 250);
            this.pb_tri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tri.TabIndex = 2;
            this.pb_tri.TabStop = false;
            // 
            // btn_mudarImagem
            // 
            this.btn_mudarImagem.Location = new System.Drawing.Point(271, 38);
            this.btn_mudarImagem.Name = "btn_mudarImagem";
            this.btn_mudarImagem.Size = new System.Drawing.Size(168, 62);
            this.btn_mudarImagem.TabIndex = 3;
            this.btn_mudarImagem.Text = "Mudar Imagem";
            this.btn_mudarImagem.UseVisualStyleBackColor = true;
            this.btn_mudarImagem.Click += new System.EventHandler(this.btn_mudarImagem_Click);
            // 
            // F_PictureBox_e_Arquivo_de_recursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 304);
            this.Controls.Add(this.btn_mudarImagem);
            this.Controls.Add(this.pb_tri);
            this.Controls.Add(this.lb_nomeCurso);
            this.Controls.Add(this.lb_meuNome);
            this.MaximizeBox = false;
            this.Name = "F_PictureBox_e_Arquivo_de_recursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureBox e Arquivo de recursos";
            this.Load += new System.EventHandler(this.F_PictureBox_e_Arquivo_de_recursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_tri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_meuNome;
        private System.Windows.Forms.Label lb_nomeCurso;
        private System.Windows.Forms.PictureBox pb_tri;
        private System.Windows.Forms.Button btn_mudarImagem;
    }
}