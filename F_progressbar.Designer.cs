namespace Componentes
{
    partial class F_progressbar
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
            this.progressBar_valor = new System.Windows.Forms.ProgressBar();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_definirValor = new System.Windows.Forms.Button();
            this.btn_preencher = new System.Windows.Forms.Button();
            this.tb_contagem = new System.Windows.Forms.TextBox();
            this.lb_valorI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar_valor
            // 
            this.progressBar_valor.Location = new System.Drawing.Point(12, 176);
            this.progressBar_valor.Name = "progressBar_valor";
            this.progressBar_valor.Size = new System.Drawing.Size(522, 23);
            this.progressBar_valor.TabIndex = 0;
            this.progressBar_valor.Value = 20;
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(12, 12);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_valor.TabIndex = 1;
            // 
            // btn_definirValor
            // 
            this.btn_definirValor.Location = new System.Drawing.Point(118, 12);
            this.btn_definirValor.Name = "btn_definirValor";
            this.btn_definirValor.Size = new System.Drawing.Size(75, 20);
            this.btn_definirValor.TabIndex = 2;
            this.btn_definirValor.Text = "Definir valor";
            this.btn_definirValor.UseVisualStyleBackColor = true;
            this.btn_definirValor.Click += new System.EventHandler(this.btn_definirValor_Click);
            // 
            // btn_preencher
            // 
            this.btn_preencher.Location = new System.Drawing.Point(12, 147);
            this.btn_preencher.Name = "btn_preencher";
            this.btn_preencher.Size = new System.Drawing.Size(75, 23);
            this.btn_preencher.TabIndex = 3;
            this.btn_preencher.Text = "Preencher";
            this.btn_preencher.UseVisualStyleBackColor = true;
            this.btn_preencher.Click += new System.EventHandler(this.btn_preencher_Click);
            // 
            // tb_contagem
            // 
            this.tb_contagem.Location = new System.Drawing.Point(281, 12);
            this.tb_contagem.Name = "tb_contagem";
            this.tb_contagem.Size = new System.Drawing.Size(100, 20);
            this.tb_contagem.TabIndex = 4;
            this.tb_contagem.Text = "10000";
            // 
            // lb_valorI
            // 
            this.lb_valorI.AutoSize = true;
            this.lb_valorI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valorI.Location = new System.Drawing.Point(286, 47);
            this.lb_valorI.Name = "lb_valorI";
            this.lb_valorI.Size = new System.Drawing.Size(94, 25);
            this.lb_valorI.TabIndex = 5;
            this.lb_valorI.Text = "Valor do i";
            this.lb_valorI.TextChanged += new System.EventHandler(this.lb_valorI_TextChanged);
            // 
            // F_progressbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 213);
            this.Controls.Add(this.lb_valorI);
            this.Controls.Add(this.tb_contagem);
            this.Controls.Add(this.btn_preencher);
            this.Controls.Add(this.btn_definirValor);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.progressBar_valor);
            this.MaximizeBox = false;
            this.Name = "F_progressbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progressbar";
            this.Load += new System.EventHandler(this.F_progressbar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_valor;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_definirValor;
        private System.Windows.Forms.Button btn_preencher;
        private System.Windows.Forms.TextBox tb_contagem;
        private System.Windows.Forms.Label lb_valorI;
    }
}