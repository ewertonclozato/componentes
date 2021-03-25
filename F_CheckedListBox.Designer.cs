namespace Componentes
{
    partial class F_CheckedListBox
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
            this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_limparLista = new System.Windows.Forms.Button();
            this.btn_resetarLista = new System.Windows.Forms.Button();
            this.lb_adcTransporte = new System.Windows.Forms.Label();
            this.tb_adctransporte = new System.Windows.Forms.TextBox();
            this.btn_adcTransporte = new System.Windows.Forms.Button();
            this.clb_listaTransportes = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_mostrarSelecionados
            // 
            this.btn_mostrarSelecionados.Location = new System.Drawing.Point(152, 107);
            this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            this.btn_mostrarSelecionados.Size = new System.Drawing.Size(216, 47);
            this.btn_mostrarSelecionados.TabIndex = 1;
            this.btn_mostrarSelecionados.Text = "Mostrar Selecionaos";
            this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
            // 
            // btn_limparLista
            // 
            this.btn_limparLista.Location = new System.Drawing.Point(152, 160);
            this.btn_limparLista.Name = "btn_limparLista";
            this.btn_limparLista.Size = new System.Drawing.Size(216, 50);
            this.btn_limparLista.TabIndex = 2;
            this.btn_limparLista.Text = "Limpar lista";
            this.btn_limparLista.UseVisualStyleBackColor = true;
            this.btn_limparLista.Click += new System.EventHandler(this.btn_limparLista_Click);
            // 
            // btn_resetarLista
            // 
            this.btn_resetarLista.Location = new System.Drawing.Point(152, 216);
            this.btn_resetarLista.Name = "btn_resetarLista";
            this.btn_resetarLista.Size = new System.Drawing.Size(216, 45);
            this.btn_resetarLista.TabIndex = 3;
            this.btn_resetarLista.Text = "Resetar a lista";
            this.btn_resetarLista.UseVisualStyleBackColor = true;
            this.btn_resetarLista.Click += new System.EventHandler(this.btn_resetarLista_Click);
            // 
            // lb_adcTransporte
            // 
            this.lb_adcTransporte.AutoSize = true;
            this.lb_adcTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_adcTransporte.Location = new System.Drawing.Point(88, 9);
            this.lb_adcTransporte.Name = "lb_adcTransporte";
            this.lb_adcTransporte.Size = new System.Drawing.Size(200, 25);
            this.lb_adcTransporte.TabIndex = 4;
            this.lb_adcTransporte.Text = "Adicionar Transporte:";
            // 
            // tb_adctransporte
            // 
            this.tb_adctransporte.Location = new System.Drawing.Point(12, 45);
            this.tb_adctransporte.Name = "tb_adctransporte";
            this.tb_adctransporte.Size = new System.Drawing.Size(355, 20);
            this.tb_adctransporte.TabIndex = 5;
            // 
            // btn_adcTransporte
            // 
            this.btn_adcTransporte.Location = new System.Drawing.Point(12, 71);
            this.btn_adcTransporte.Name = "btn_adcTransporte";
            this.btn_adcTransporte.Size = new System.Drawing.Size(355, 30);
            this.btn_adcTransporte.TabIndex = 6;
            this.btn_adcTransporte.Text = "Adicionar";
            this.btn_adcTransporte.UseVisualStyleBackColor = true;
            this.btn_adcTransporte.Click += new System.EventHandler(this.btn_adcTransporte_Click);
            // 
            // clb_listaTransportes
            // 
            this.clb_listaTransportes.CheckOnClick = true;
            this.clb_listaTransportes.FormattingEnabled = true;
            this.clb_listaTransportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Moto",
            "Navio"});
            this.clb_listaTransportes.Location = new System.Drawing.Point(12, 107);
            this.clb_listaTransportes.Name = "clb_listaTransportes";
            this.clb_listaTransportes.Size = new System.Drawing.Size(134, 154);
            this.clb_listaTransportes.TabIndex = 7;
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 271);
            this.Controls.Add(this.clb_listaTransportes);
            this.Controls.Add(this.btn_adcTransporte);
            this.Controls.Add(this.tb_adctransporte);
            this.Controls.Add(this.lb_adcTransporte);
            this.Controls.Add(this.btn_resetarLista);
            this.Controls.Add(this.btn_limparLista);
            this.Controls.Add(this.btn_mostrarSelecionados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_CheckedListBox_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_mostrarSelecionados;
        private System.Windows.Forms.Button btn_limparLista;
        private System.Windows.Forms.Button btn_resetarLista;
        private System.Windows.Forms.Label lb_adcTransporte;
        private System.Windows.Forms.TextBox tb_adctransporte;
        private System.Windows.Forms.Button btn_adcTransporte;
        private System.Windows.Forms.CheckedListBox clb_listaTransportes;
    }
}