namespace Componentes
{
    partial class F_WebBrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.pb_desfazer = new System.Windows.Forms.PictureBox();
            this.pb_refazer = new System.Windows.Forms.PictureBox();
            this.pb_recarregar = new System.Windows.Forms.PictureBox();
            this.pb_parar = new System.Windows.Forms.PictureBox();
            this.pb_home = new System.Windows.Forms.PictureBox();
            this.pb_ir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desfazer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_refazer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_recarregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_parar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ir)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 38);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(753, 412);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.webBrowser1_ControlAdded);
            this.webBrowser1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.webBrowser1_ControlRemoved);
            // 
            // tb_url
            // 
            this.tb_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_url.Location = new System.Drawing.Point(134, 12);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(588, 20);
            this.tb_url.TabIndex = 1;
            this.tb_url.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_url_MouseClick);
            this.tb_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_url_KeyDown);
            // 
            // pb_desfazer
            // 
            this.pb_desfazer.Image = global::Componentes.Properties.Resources.desfazer;
            this.pb_desfazer.Location = new System.Drawing.Point(30, 12);
            this.pb_desfazer.Name = "pb_desfazer";
            this.pb_desfazer.Size = new System.Drawing.Size(20, 20);
            this.pb_desfazer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_desfazer.TabIndex = 2;
            this.pb_desfazer.TabStop = false;
            this.pb_desfazer.Click += new System.EventHandler(this.pb_desfazer_Click);
            // 
            // pb_refazer
            // 
            this.pb_refazer.Image = global::Componentes.Properties.Resources.refazer;
            this.pb_refazer.Location = new System.Drawing.Point(56, 12);
            this.pb_refazer.Name = "pb_refazer";
            this.pb_refazer.Size = new System.Drawing.Size(20, 20);
            this.pb_refazer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_refazer.TabIndex = 3;
            this.pb_refazer.TabStop = false;
            this.pb_refazer.Click += new System.EventHandler(this.pb_refazer_Click);
            // 
            // pb_recarregar
            // 
            this.pb_recarregar.Image = global::Componentes.Properties.Resources.recarregar;
            this.pb_recarregar.Location = new System.Drawing.Point(82, 12);
            this.pb_recarregar.Name = "pb_recarregar";
            this.pb_recarregar.Size = new System.Drawing.Size(20, 20);
            this.pb_recarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_recarregar.TabIndex = 4;
            this.pb_recarregar.TabStop = false;
            this.pb_recarregar.Click += new System.EventHandler(this.pb_recarregar_Click);
            // 
            // pb_parar
            // 
            this.pb_parar.Image = global::Componentes.Properties.Resources.parar;
            this.pb_parar.Location = new System.Drawing.Point(108, 12);
            this.pb_parar.Name = "pb_parar";
            this.pb_parar.Size = new System.Drawing.Size(20, 20);
            this.pb_parar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_parar.TabIndex = 5;
            this.pb_parar.TabStop = false;
            this.pb_parar.Click += new System.EventHandler(this.pb_parar_Click);
            // 
            // pb_home
            // 
            this.pb_home.Image = global::Componentes.Properties.Resources.home;
            this.pb_home.Location = new System.Drawing.Point(4, 12);
            this.pb_home.Name = "pb_home";
            this.pb_home.Size = new System.Drawing.Size(20, 20);
            this.pb_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_home.TabIndex = 6;
            this.pb_home.TabStop = false;
            this.pb_home.Click += new System.EventHandler(this.pb_home_Click);
            // 
            // pb_ir
            // 
            this.pb_ir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_ir.Image = global::Componentes.Properties.Resources.ir;
            this.pb_ir.Location = new System.Drawing.Point(728, 12);
            this.pb_ir.Name = "pb_ir";
            this.pb_ir.Size = new System.Drawing.Size(20, 20);
            this.pb_ir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ir.TabIndex = 7;
            this.pb_ir.TabStop = false;
            this.pb_ir.Click += new System.EventHandler(this.pb_ir_Click);
            // 
            // F_WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.pb_ir);
            this.Controls.Add(this.pb_home);
            this.Controls.Add(this.pb_parar);
            this.Controls.Add(this.pb_recarregar);
            this.Controls.Add(this.pb_refazer);
            this.Controls.Add(this.pb_desfazer);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_WebBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.F_WebBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_desfazer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_refazer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_recarregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_parar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.PictureBox pb_desfazer;
        private System.Windows.Forms.PictureBox pb_refazer;
        private System.Windows.Forms.PictureBox pb_recarregar;
        private System.Windows.Forms.PictureBox pb_parar;
        private System.Windows.Forms.PictureBox pb_home;
        private System.Windows.Forms.PictureBox pb_ir;
    }
}