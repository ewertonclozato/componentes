namespace Componentes
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.lb_digite = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.tb_listaVeiculos = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_mostrarLista = new System.Windows.Forms.Button();
            this.btn_listaDictionary = new System.Windows.Forms.Button();
            this.btn_valNum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkdListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBoxMáscaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxEArquivoDeRecursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundworkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_digite
            // 
            this.lb_digite.AutoSize = true;
            this.lb_digite.Location = new System.Drawing.Point(14, 31);
            this.lb_digite.Name = "lb_digite";
            this.lb_digite.Size = new System.Drawing.Size(91, 13);
            this.lb_digite.TabIndex = 0;
            this.lb_digite.Text = "Digite um Veículo";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(202, 49);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 20);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(11, 49);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(185, 20);
            this.tb_veiculo.TabIndex = 2;
            // 
            // tb_listaVeiculos
            // 
            this.tb_listaVeiculos.Location = new System.Drawing.Point(11, 75);
            this.tb_listaVeiculos.Multiline = true;
            this.tb_listaVeiculos.Name = "tb_listaVeiculos";
            this.tb_listaVeiculos.Size = new System.Drawing.Size(266, 245);
            this.tb_listaVeiculos.TabIndex = 3;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(11, 326);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(266, 29);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_mostrarLista
            // 
            this.btn_mostrarLista.Location = new System.Drawing.Point(11, 361);
            this.btn_mostrarLista.Name = "btn_mostrarLista";
            this.btn_mostrarLista.Size = new System.Drawing.Size(266, 53);
            this.btn_mostrarLista.TabIndex = 5;
            this.btn_mostrarLista.Text = "Mostrar lista";
            this.btn_mostrarLista.UseVisualStyleBackColor = true;
            this.btn_mostrarLista.Click += new System.EventHandler(this.btn_mostrarLista_Click);
            // 
            // btn_listaDictionary
            // 
            this.btn_listaDictionary.Location = new System.Drawing.Point(11, 420);
            this.btn_listaDictionary.Name = "btn_listaDictionary";
            this.btn_listaDictionary.Size = new System.Drawing.Size(266, 53);
            this.btn_listaDictionary.TabIndex = 6;
            this.btn_listaDictionary.Text = "Lista com Dictionary";
            this.btn_listaDictionary.UseVisualStyleBackColor = true;
            this.btn_listaDictionary.Click += new System.EventHandler(this.btn_listaDictionary_Click);
            // 
            // btn_valNum
            // 
            this.btn_valNum.Location = new System.Drawing.Point(11, 477);
            this.btn_valNum.Name = "btn_valNum";
            this.btn_valNum.Size = new System.Drawing.Size(266, 53);
            this.btn_valNum.TabIndex = 7;
            this.btn_valNum.Text = "Valor de NUM";
            this.btn_valNum.UseVisualStyleBackColor = true;
            this.btn_valNum.Click += new System.EventHandler(this.btn_valNum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem,
            this.sQLiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(289, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.checkdListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem,
            this.linkLabelToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedTextBoxMáscaraToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.numericUpDownToolStripMenuItem,
            this.pictureBoxEArquivoDeRecursosToolStripMenuItem,
            this.progressbarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.webBrowserToolStripMenuItem,
            this.splitContainerToolStripMenuItem,
            this.toolStripMenuItem4,
            this.tableLayoutPanelToolStripMenuItem,
            this.toolStripContainerToolStripMenuItem,
            this.backgroundworkerToolStripMenuItem,
            this.toolStripMenuItem5});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.checkBoxToolStripMenuItem.Text = "Check Box";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // checkdListBoxToolStripMenuItem
            // 
            this.checkdListBoxToolStripMenuItem.Name = "checkdListBoxToolStripMenuItem";
            this.checkdListBoxToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.checkdListBoxToolStripMenuItem.Text = "Checkd List Box";
            this.checkdListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkdListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.comboBoxToolStripMenuItem.Text = "Combo Box";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.dateTimePickerToolStripMenuItem.Text = "Date Time Picker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // linkLabelToolStripMenuItem
            // 
            this.linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            this.linkLabelToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.linkLabelToolStripMenuItem.Text = "LinkLabel";
            this.linkLabelToolStripMenuItem.Click += new System.EventHandler(this.linkLabelToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.listBoxToolStripMenuItem.Text = "List Box";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.listViewToolStripMenuItem.Text = "List View";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // maskedTextBoxMáscaraToolStripMenuItem
            // 
            this.maskedTextBoxMáscaraToolStripMenuItem.Name = "maskedTextBoxMáscaraToolStripMenuItem";
            this.maskedTextBoxMáscaraToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.maskedTextBoxMáscaraToolStripMenuItem.Text = "MaskedTextBox / Máscara";
            this.maskedTextBoxMáscaraToolStripMenuItem.Click += new System.EventHandler(this.maskedTextBoxMáscaraToolStripMenuItem_Click);
            // 
            // monthCalendarToolStripMenuItem
            // 
            this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.monthCalendarToolStripMenuItem.Text = "Month Calendar";
            this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // numericUpDownToolStripMenuItem
            // 
            this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
            this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.numericUpDownToolStripMenuItem.Text = "Numeric Up Down";
            this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
            // 
            // pictureBoxEArquivoDeRecursosToolStripMenuItem
            // 
            this.pictureBoxEArquivoDeRecursosToolStripMenuItem.Name = "pictureBoxEArquivoDeRecursosToolStripMenuItem";
            this.pictureBoxEArquivoDeRecursosToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.pictureBoxEArquivoDeRecursosToolStripMenuItem.Text = "PictureBox e Arquivo de recursos";
            this.pictureBoxEArquivoDeRecursosToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxEArquivoDeRecursosToolStripMenuItem_Click);
            // 
            // progressbarToolStripMenuItem
            // 
            this.progressbarToolStripMenuItem.Name = "progressbarToolStripMenuItem";
            this.progressbarToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.progressbarToolStripMenuItem.Text = "Progressbar";
            this.progressbarToolStripMenuItem.Click += new System.EventHandler(this.progressbarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(248, 22);
            this.toolStripMenuItem1.Text = "Radiobutton";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(248, 22);
            this.toolStripMenuItem2.Text = "Track Bar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(248, 22);
            this.toolStripMenuItem3.Text = "Tree View";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // webBrowserToolStripMenuItem
            // 
            this.webBrowserToolStripMenuItem.Name = "webBrowserToolStripMenuItem";
            this.webBrowserToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.webBrowserToolStripMenuItem.Text = "Web Browser";
            this.webBrowserToolStripMenuItem.Click += new System.EventHandler(this.webBrowserToolStripMenuItem_Click);
            // 
            // splitContainerToolStripMenuItem
            // 
            this.splitContainerToolStripMenuItem.Name = "splitContainerToolStripMenuItem";
            this.splitContainerToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.splitContainerToolStripMenuItem.Text = "SplitContainer";
            this.splitContainerToolStripMenuItem.Click += new System.EventHandler(this.splitContainerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(248, 22);
            this.toolStripMenuItem4.Text = "TabControl";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // tableLayoutPanelToolStripMenuItem
            // 
            this.tableLayoutPanelToolStripMenuItem.Name = "tableLayoutPanelToolStripMenuItem";
            this.tableLayoutPanelToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.tableLayoutPanelToolStripMenuItem.Text = "Table Layout Panel";
            this.tableLayoutPanelToolStripMenuItem.Click += new System.EventHandler(this.tableLayoutPanelToolStripMenuItem_Click);
            // 
            // toolStripContainerToolStripMenuItem
            // 
            this.toolStripContainerToolStripMenuItem.Name = "toolStripContainerToolStripMenuItem";
            this.toolStripContainerToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.toolStripContainerToolStripMenuItem.Text = "Tool Strip Container";
            this.toolStripContainerToolStripMenuItem.Click += new System.EventHandler(this.toolStripContainerToolStripMenuItem_Click);
            // 
            // backgroundworkerToolStripMenuItem
            // 
            this.backgroundworkerToolStripMenuItem.Name = "backgroundworkerToolStripMenuItem";
            this.backgroundworkerToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.backgroundworkerToolStripMenuItem.Text = "Backgroundworker";
            this.backgroundworkerToolStripMenuItem.Click += new System.EventHandler(this.backgroundworkerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(248, 22);
            this.toolStripMenuItem5.Text = "Timer";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // sQLiteToolStripMenuItem
            // 
            this.sQLiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.sQLiteToolStripMenuItem.Name = "sQLiteToolStripMenuItem";
            this.sQLiteToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sQLiteToolStripMenuItem.Text = "SQLite";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "SQLite";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.Menu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Componentes";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Restaurar,
            this.Mensagem,
            this.Fechar});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(134, 70);
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // Restaurar
            // 
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(133, 22);
            this.Restaurar.Text = "Restaurar";
            // 
            // Mensagem
            // 
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(133, 22);
            this.Mensagem.Text = "Mensagem";
            // 
            // Fechar
            // 
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(133, 22);
            this.Fechar.Text = "Fechar";
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(289, 541);
            this.Controls.Add(this.btn_valNum);
            this.Controls.Add(this.btn_listaDictionary);
            this.Controls.Add(this.btn_mostrarLista);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.tb_listaVeiculos);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.lb_digite);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes_Curso";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_Principal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_digite;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_mostrarLista;
        private System.Windows.Forms.Button btn_listaDictionary;
        public System.Windows.Forms.TextBox tb_listaVeiculos;
        private System.Windows.Forms.Button btn_valNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkdListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskedTextBoxMáscaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthCalendarToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Restaurar;
        private System.Windows.Forms.ToolStripMenuItem Mensagem;
        private System.Windows.Forms.ToolStripMenuItem Fechar;
        private System.Windows.Forms.ToolStripMenuItem numericUpDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureBoxEArquivoDeRecursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem webBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tableLayoutPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundworkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem sQLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}

