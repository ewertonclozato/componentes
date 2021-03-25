namespace Componentes
{
    partial class F_ComboBox
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_resetarTransportes = new System.Windows.Forms.Button();
            this.btn_adcTransportes = new System.Windows.Forms.Button();
            this.btn_limparTransportes = new System.Windows.Forms.Button();
            this.tb_transporte = new System.Windows.Forms.TextBox();
            this.btn_deletarTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Avião",
            "Navio"});
            this.cb_transportes.Location = new System.Drawing.Point(12, 16);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(388, 21);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionado
            // 
            this.btn_mostrarSelecionado.Location = new System.Drawing.Point(12, 43);
            this.btn_mostrarSelecionado.Name = "btn_mostrarSelecionado";
            this.btn_mostrarSelecionado.Size = new System.Drawing.Size(137, 23);
            this.btn_mostrarSelecionado.TabIndex = 1;
            this.btn_mostrarSelecionado.Text = "Mostrar selecionado";
            this.btn_mostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionado.Click += new System.EventHandler(this.btn_mostrarSelecionado_Click);
            // 
            // btn_resetarTransportes
            // 
            this.btn_resetarTransportes.Location = new System.Drawing.Point(12, 101);
            this.btn_resetarTransportes.Name = "btn_resetarTransportes";
            this.btn_resetarTransportes.Size = new System.Drawing.Size(137, 23);
            this.btn_resetarTransportes.TabIndex = 2;
            this.btn_resetarTransportes.Text = "Resetar transportes";
            this.btn_resetarTransportes.UseVisualStyleBackColor = true;
            this.btn_resetarTransportes.Click += new System.EventHandler(this.btn_resetarElementos_Click);
            // 
            // btn_adcTransportes
            // 
            this.btn_adcTransportes.Location = new System.Drawing.Point(12, 156);
            this.btn_adcTransportes.Name = "btn_adcTransportes";
            this.btn_adcTransportes.Size = new System.Drawing.Size(193, 23);
            this.btn_adcTransportes.TabIndex = 3;
            this.btn_adcTransportes.Text = "Adicionar Transportes";
            this.btn_adcTransportes.UseVisualStyleBackColor = true;
            this.btn_adcTransportes.Click += new System.EventHandler(this.btn_adcElemento_Click);
            // 
            // btn_limparTransportes
            // 
            this.btn_limparTransportes.Location = new System.Drawing.Point(12, 72);
            this.btn_limparTransportes.Name = "btn_limparTransportes";
            this.btn_limparTransportes.Size = new System.Drawing.Size(137, 23);
            this.btn_limparTransportes.TabIndex = 5;
            this.btn_limparTransportes.Text = "Limpar transportes";
            this.btn_limparTransportes.UseVisualStyleBackColor = true;
            this.btn_limparTransportes.Click += new System.EventHandler(this.btn_limparElementos_Click);
            // 
            // tb_transporte
            // 
            this.tb_transporte.Location = new System.Drawing.Point(12, 130);
            this.tb_transporte.Name = "tb_transporte";
            this.tb_transporte.Size = new System.Drawing.Size(388, 20);
            this.tb_transporte.TabIndex = 6;
            // 
            // btn_deletarTransporte
            // 
            this.btn_deletarTransporte.Location = new System.Drawing.Point(211, 156);
            this.btn_deletarTransporte.Name = "btn_deletarTransporte";
            this.btn_deletarTransporte.Size = new System.Drawing.Size(189, 23);
            this.btn_deletarTransporte.TabIndex = 7;
            this.btn_deletarTransporte.Text = "Deletar Transporte";
            this.btn_deletarTransporte.UseVisualStyleBackColor = true;
            this.btn_deletarTransporte.Click += new System.EventHandler(this.btn_deletarTransporte_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 214);
            this.Controls.Add(this.btn_deletarTransporte);
            this.Controls.Add(this.tb_transporte);
            this.Controls.Add(this.btn_limparTransportes);
            this.Controls.Add(this.btn_adcTransportes);
            this.Controls.Add(this.btn_resetarTransportes);
            this.Controls.Add(this.btn_mostrarSelecionado);
            this.Controls.Add(this.cb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo Box";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_ComboBox_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_mostrarSelecionado;
        private System.Windows.Forms.Button btn_resetarTransportes;
        private System.Windows.Forms.Button btn_adcTransportes;
        private System.Windows.Forms.Button btn_limparTransportes;
        private System.Windows.Forms.TextBox tb_transporte;
        private System.Windows.Forms.Button btn_deletarTransporte;
    }
}