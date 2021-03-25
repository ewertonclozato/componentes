namespace Componentes
{
    partial class F_MonthCalendar
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
            this.mc_calendario = new System.Windows.Forms.MonthCalendar();
            this.btn_pegarData = new System.Windows.Forms.Button();
            this.tb_dataHoje = new System.Windows.Forms.TextBox();
            this.tb_dataInicial = new System.Windows.Forms.TextBox();
            this.tb_dataFinal = new System.Windows.Forms.TextBox();
            this.lb_hoje = new System.Windows.Forms.Label();
            this.lb_dataInicial = new System.Windows.Forms.Label();
            this.lb_dataFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mc_calendario
            // 
            this.mc_calendario.Location = new System.Drawing.Point(9, 10);
            this.mc_calendario.MaxSelectionCount = 30;
            this.mc_calendario.Name = "mc_calendario";
            this.mc_calendario.TabIndex = 0;
            this.mc_calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mc_calendario_DateChanged);
            this.mc_calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mc_calendario_DateSelected);
            // 
            // btn_pegarData
            // 
            this.btn_pegarData.Location = new System.Drawing.Point(248, 15);
            this.btn_pegarData.Name = "btn_pegarData";
            this.btn_pegarData.Size = new System.Drawing.Size(193, 32);
            this.btn_pegarData.TabIndex = 1;
            this.btn_pegarData.Text = "Pegar Data";
            this.btn_pegarData.UseVisualStyleBackColor = true;
            this.btn_pegarData.Click += new System.EventHandler(this.btn_pegarData_Click);
            // 
            // tb_dataHoje
            // 
            this.tb_dataHoje.Location = new System.Drawing.Point(248, 66);
            this.tb_dataHoje.Name = "tb_dataHoje";
            this.tb_dataHoje.Size = new System.Drawing.Size(192, 20);
            this.tb_dataHoje.TabIndex = 2;
            // 
            // tb_dataInicial
            // 
            this.tb_dataInicial.Location = new System.Drawing.Point(248, 105);
            this.tb_dataInicial.Name = "tb_dataInicial";
            this.tb_dataInicial.Size = new System.Drawing.Size(192, 20);
            this.tb_dataInicial.TabIndex = 3;
            this.tb_dataInicial.TextChanged += new System.EventHandler(this.tb_dataInicial_TextChanged);
            // 
            // tb_dataFinal
            // 
            this.tb_dataFinal.Location = new System.Drawing.Point(248, 144);
            this.tb_dataFinal.Name = "tb_dataFinal";
            this.tb_dataFinal.Size = new System.Drawing.Size(192, 20);
            this.tb_dataFinal.TabIndex = 4;
            // 
            // lb_hoje
            // 
            this.lb_hoje.AutoSize = true;
            this.lb_hoje.Location = new System.Drawing.Point(245, 50);
            this.lb_hoje.Name = "lb_hoje";
            this.lb_hoje.Size = new System.Drawing.Size(29, 13);
            this.lb_hoje.TabIndex = 5;
            this.lb_hoje.Text = "Hoje";
            // 
            // lb_dataInicial
            // 
            this.lb_dataInicial.AutoSize = true;
            this.lb_dataInicial.Location = new System.Drawing.Point(245, 89);
            this.lb_dataInicial.Name = "lb_dataInicial";
            this.lb_dataInicial.Size = new System.Drawing.Size(60, 13);
            this.lb_dataInicial.TabIndex = 6;
            this.lb_dataInicial.Text = "Data Inicial";
            // 
            // lb_dataFinal
            // 
            this.lb_dataFinal.AutoSize = true;
            this.lb_dataFinal.Location = new System.Drawing.Point(245, 128);
            this.lb_dataFinal.Name = "lb_dataFinal";
            this.lb_dataFinal.Size = new System.Drawing.Size(55, 13);
            this.lb_dataFinal.TabIndex = 7;
            this.lb_dataFinal.Text = "Data Final";
            // 
            // F_MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 185);
            this.Controls.Add(this.lb_dataFinal);
            this.Controls.Add(this.lb_dataInicial);
            this.Controls.Add(this.lb_hoje);
            this.Controls.Add(this.tb_dataFinal);
            this.Controls.Add(this.tb_dataInicial);
            this.Controls.Add(this.tb_dataHoje);
            this.Controls.Add(this.btn_pegarData);
            this.Controls.Add(this.mc_calendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_MonthCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Month Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mc_calendario;
        private System.Windows.Forms.Button btn_pegarData;
        private System.Windows.Forms.TextBox tb_dataHoje;
        private System.Windows.Forms.TextBox tb_dataInicial;
        private System.Windows.Forms.TextBox tb_dataFinal;
        private System.Windows.Forms.Label lb_hoje;
        private System.Windows.Forms.Label lb_dataInicial;
        private System.Windows.Forms.Label lb_dataFinal;
    }
}