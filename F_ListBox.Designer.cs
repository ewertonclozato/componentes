namespace Componentes
{
    partial class F_ListBox
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
            this.lib_carro = new System.Windows.Forms.ListBox();
            this.tb_adcCarro = new System.Windows.Forms.TextBox();
            this.lb_carro = new System.Windows.Forms.Label();
            this.btn_adc = new System.Windows.Forms.Button();
            this.btn_rmover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.tb_carroObtido = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lib_carro
            // 
            this.lib_carro.FormattingEnabled = true;
            this.lib_carro.Location = new System.Drawing.Point(12, 12);
            this.lib_carro.Name = "lib_carro";
            this.lib_carro.Size = new System.Drawing.Size(142, 160);
            this.lib_carro.TabIndex = 0;
            // 
            // tb_adcCarro
            // 
            this.tb_adcCarro.Location = new System.Drawing.Point(160, 29);
            this.tb_adcCarro.Name = "tb_adcCarro";
            this.tb_adcCarro.Size = new System.Drawing.Size(128, 20);
            this.tb_adcCarro.TabIndex = 1;
            // 
            // lb_carro
            // 
            this.lb_carro.AutoSize = true;
            this.lb_carro.Location = new System.Drawing.Point(160, 12);
            this.lb_carro.Name = "lb_carro";
            this.lb_carro.Size = new System.Drawing.Size(81, 13);
            this.lb_carro.TabIndex = 2;
            this.lb_carro.Text = "Adicionar carro:";
            // 
            // btn_adc
            // 
            this.btn_adc.Location = new System.Drawing.Point(160, 55);
            this.btn_adc.Name = "btn_adc";
            this.btn_adc.Size = new System.Drawing.Size(128, 23);
            this.btn_adc.TabIndex = 3;
            this.btn_adc.Text = "Adicionar";
            this.btn_adc.UseVisualStyleBackColor = true;
            this.btn_adc.Click += new System.EventHandler(this.btn_adc_Click);
            // 
            // btn_rmover
            // 
            this.btn_rmover.Location = new System.Drawing.Point(160, 84);
            this.btn_rmover.Name = "btn_rmover";
            this.btn_rmover.Size = new System.Drawing.Size(128, 23);
            this.btn_rmover.TabIndex = 4;
            this.btn_rmover.Text = "Remover";
            this.btn_rmover.UseVisualStyleBackColor = true;
            this.btn_rmover.Click += new System.EventHandler(this.btn_rmover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(160, 113);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(128, 23);
            this.btn_obter.TabIndex = 5;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // tb_carroObtido
            // 
            this.tb_carroObtido.Location = new System.Drawing.Point(162, 144);
            this.tb_carroObtido.Name = "tb_carroObtido";
            this.tb_carroObtido.Size = new System.Drawing.Size(125, 20);
            this.tb_carroObtido.TabIndex = 6;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(15, 178);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(271, 28);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "Limpar TUDO";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 210);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.tb_carroObtido);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_rmover);
            this.Controls.Add(this.btn_adc);
            this.Controls.Add(this.lb_carro);
            this.Controls.Add(this.tb_adcCarro);
            this.Controls.Add(this.lib_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lib_carro;
        private System.Windows.Forms.TextBox tb_adcCarro;
        private System.Windows.Forms.Label lb_carro;
        private System.Windows.Forms.Button btn_adc;
        private System.Windows.Forms.Button btn_rmover;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.TextBox tb_carroObtido;
        private System.Windows.Forms.Button btn_limpar;
    }
}