namespace Componentes
{
    partial class F_DateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.tb_dataCompleta = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.btn_obterData = new System.Windows.Forms.Button();
            this.btn_setarData = new System.Windows.Forms.Button();
            this.btn_hoje = new System.Windows.Forms.Button();
            this.lb_dia = new System.Windows.Forms.Label();
            this.lb_mes = new System.Windows.Forms.Label();
            this.lb_ano = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(14, 16);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(416, 20);
            this.dtp_data.TabIndex = 0;
            // 
            // tb_dataCompleta
            // 
            this.tb_dataCompleta.Location = new System.Drawing.Point(14, 45);
            this.tb_dataCompleta.Name = "tb_dataCompleta";
            this.tb_dataCompleta.Size = new System.Drawing.Size(415, 20);
            this.tb_dataCompleta.TabIndex = 1;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(14, 86);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(135, 20);
            this.tb_dia.TabIndex = 2;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(154, 86);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(133, 20);
            this.tb_mes.TabIndex = 3;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(296, 86);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(135, 20);
            this.tb_ano.TabIndex = 4;
            // 
            // btn_obterData
            // 
            this.btn_obterData.Location = new System.Drawing.Point(14, 116);
            this.btn_obterData.Name = "btn_obterData";
            this.btn_obterData.Size = new System.Drawing.Size(134, 28);
            this.btn_obterData.TabIndex = 5;
            this.btn_obterData.Text = "Obter data";
            this.btn_obterData.UseVisualStyleBackColor = true;
            this.btn_obterData.Click += new System.EventHandler(this.btn_obterData_Click);
            // 
            // btn_setarData
            // 
            this.btn_setarData.Location = new System.Drawing.Point(154, 116);
            this.btn_setarData.Name = "btn_setarData";
            this.btn_setarData.Size = new System.Drawing.Size(136, 28);
            this.btn_setarData.TabIndex = 6;
            this.btn_setarData.Text = "Setar data";
            this.btn_setarData.UseVisualStyleBackColor = true;
            this.btn_setarData.Click += new System.EventHandler(this.btn_setarData_Click);
            // 
            // btn_hoje
            // 
            this.btn_hoje.Location = new System.Drawing.Point(296, 116);
            this.btn_hoje.Name = "btn_hoje";
            this.btn_hoje.Size = new System.Drawing.Size(134, 28);
            this.btn_hoje.TabIndex = 7;
            this.btn_hoje.Text = "Data de hoie";
            this.btn_hoje.UseVisualStyleBackColor = true;
            // 
            // lb_dia
            // 
            this.lb_dia.AutoSize = true;
            this.lb_dia.Location = new System.Drawing.Point(15, 70);
            this.lb_dia.Name = "lb_dia";
            this.lb_dia.Size = new System.Drawing.Size(23, 13);
            this.lb_dia.TabIndex = 8;
            this.lb_dia.Text = "Dia";
            // 
            // lb_mes
            // 
            this.lb_mes.AutoSize = true;
            this.lb_mes.Location = new System.Drawing.Point(155, 70);
            this.lb_mes.Name = "lb_mes";
            this.lb_mes.Size = new System.Drawing.Size(27, 13);
            this.lb_mes.TabIndex = 9;
            this.lb_mes.Text = "Mes";
            // 
            // lb_ano
            // 
            this.lb_ano.AutoSize = true;
            this.lb_ano.Location = new System.Drawing.Point(296, 70);
            this.lb_ano.Name = "lb_ano";
            this.lb_ano.Size = new System.Drawing.Size(26, 13);
            this.lb_ano.TabIndex = 10;
            this.lb_ano.Text = "Ano";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(18, 156);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(411, 77);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "LIMPAR TUDO";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lb_ano);
            this.Controls.Add(this.lb_mes);
            this.Controls.Add(this.lb_dia);
            this.Controls.Add(this.btn_hoje);
            this.Controls.Add(this.btn_setarData);
            this.Controls.Add(this.btn_obterData);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_dataCompleta);
            this.Controls.Add(this.dtp_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_DateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Time Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.TextBox tb_dataCompleta;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Button btn_obterData;
        private System.Windows.Forms.Button btn_setarData;
        private System.Windows.Forms.Button btn_hoje;
        private System.Windows.Forms.Label lb_dia;
        private System.Windows.Forms.Label lb_mes;
        private System.Windows.Forms.Label lb_ano;
        private System.Windows.Forms.Button btn_limpar;
    }
}