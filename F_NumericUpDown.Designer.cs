namespace Componentes
{
    partial class F_NumericUpDown
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
            this.nud_valor = new System.Windows.Forms.NumericUpDown();
            this.tb_definirValor = new System.Windows.Forms.TextBox();
            this.tb_obterValor = new System.Windows.Forms.TextBox();
            this.btn_definirValor = new System.Windows.Forms.Button();
            this.btn_obterValor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_valor
            // 
            this.nud_valor.DecimalPlaces = 2;
            this.nud_valor.Location = new System.Drawing.Point(12, 12);
            this.nud_valor.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_valor.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nud_valor.Name = "nud_valor";
            this.nud_valor.Size = new System.Drawing.Size(120, 20);
            this.nud_valor.TabIndex = 0;
            // 
            // tb_definirValor
            // 
            this.tb_definirValor.Location = new System.Drawing.Point(140, 12);
            this.tb_definirValor.Name = "tb_definirValor";
            this.tb_definirValor.Size = new System.Drawing.Size(100, 20);
            this.tb_definirValor.TabIndex = 1;
            this.tb_definirValor.Text = "0";
            // 
            // tb_obterValor
            // 
            this.tb_obterValor.Location = new System.Drawing.Point(12, 38);
            this.tb_obterValor.Name = "tb_obterValor";
            this.tb_obterValor.Size = new System.Drawing.Size(120, 20);
            this.tb_obterValor.TabIndex = 2;
            // 
            // btn_definirValor
            // 
            this.btn_definirValor.Location = new System.Drawing.Point(246, 12);
            this.btn_definirValor.Name = "btn_definirValor";
            this.btn_definirValor.Size = new System.Drawing.Size(96, 20);
            this.btn_definirValor.TabIndex = 3;
            this.btn_definirValor.Text = "Definir valor";
            this.btn_definirValor.UseVisualStyleBackColor = true;
            this.btn_definirValor.Click += new System.EventHandler(this.btn_definirValor_Click);
            // 
            // btn_obterValor
            // 
            this.btn_obterValor.Location = new System.Drawing.Point(140, 38);
            this.btn_obterValor.Name = "btn_obterValor";
            this.btn_obterValor.Size = new System.Drawing.Size(100, 20);
            this.btn_obterValor.TabIndex = 4;
            this.btn_obterValor.Text = "Obter valor";
            this.btn_obterValor.UseVisualStyleBackColor = true;
            this.btn_obterValor.Click += new System.EventHandler(this.btn_obterValor_Click);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 86);
            this.Controls.Add(this.btn_obterValor);
            this.Controls.Add(this.btn_definirValor);
            this.Controls.Add(this.tb_obterValor);
            this.Controls.Add(this.tb_definirValor);
            this.Controls.Add(this.nud_valor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_NumericUpDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeric Up Down";
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_valor;
        private System.Windows.Forms.TextBox tb_definirValor;
        private System.Windows.Forms.TextBox tb_obterValor;
        private System.Windows.Forms.Button btn_definirValor;
        private System.Windows.Forms.Button btn_obterValor;
    }
}