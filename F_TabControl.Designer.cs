namespace Componentes
{
    partial class F_TabControl
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
            this.tb_novaABA = new System.Windows.Forms.TextBox();
            this.btn_novaTeb = new System.Windows.Forms.Button();
            this.btn_removerTab = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_posicionarTab = new System.Windows.Forms.Button();
            this.tab_home = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tab_home.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_novaABA
            // 
            this.tb_novaABA.Location = new System.Drawing.Point(16, 12);
            this.tb_novaABA.Name = "tb_novaABA";
            this.tb_novaABA.Size = new System.Drawing.Size(101, 20);
            this.tb_novaABA.TabIndex = 1;
            // 
            // btn_novaTeb
            // 
            this.btn_novaTeb.Location = new System.Drawing.Point(123, 12);
            this.btn_novaTeb.Name = "btn_novaTeb";
            this.btn_novaTeb.Size = new System.Drawing.Size(75, 20);
            this.btn_novaTeb.TabIndex = 2;
            this.btn_novaTeb.Text = "Nova Aba";
            this.btn_novaTeb.UseVisualStyleBackColor = true;
            this.btn_novaTeb.Click += new System.EventHandler(this.btn_novaTeb_Click);
            // 
            // btn_removerTab
            // 
            this.btn_removerTab.Location = new System.Drawing.Point(204, 12);
            this.btn_removerTab.Name = "btn_removerTab";
            this.btn_removerTab.Size = new System.Drawing.Size(75, 20);
            this.btn_removerTab.TabIndex = 3;
            this.btn_removerTab.Text = "Remover Aba";
            this.btn_removerTab.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 39);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_posicionarTab
            // 
            this.btn_posicionarTab.Location = new System.Drawing.Point(123, 39);
            this.btn_posicionarTab.Name = "btn_posicionarTab";
            this.btn_posicionarTab.Size = new System.Drawing.Size(156, 20);
            this.btn_posicionarTab.TabIndex = 5;
            this.btn_posicionarTab.Text = "Posicionar na Aba";
            this.btn_posicionarTab.UseVisualStyleBackColor = true;
            // 
            // tab_home
            // 
            this.tab_home.Controls.Add(this.webBrowser1);
            this.tab_home.Location = new System.Drawing.Point(4, 22);
            this.tab_home.Name = "tab_home";
            this.tab_home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_home.Size = new System.Drawing.Size(768, 347);
            this.tab_home.TabIndex = 0;
            this.tab_home.Text = "Home";
            this.tab_home.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_home);
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(762, 341);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_posicionarTab);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_removerTab);
            this.Controls.Add(this.btn_novaTeb);
            this.Controls.Add(this.tb_novaABA);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_TabControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TabControl";
            this.Load += new System.EventHandler(this.F_TabControl_Load);
            this.VisibleChanged += new System.EventHandler(this.F_TabControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tab_home.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_novaABA;
        private System.Windows.Forms.Button btn_novaTeb;
        private System.Windows.Forms.Button btn_removerTab;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_posicionarTab;
        private System.Windows.Forms.TabPage tab_home;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}