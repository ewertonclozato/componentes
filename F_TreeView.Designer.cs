namespace Componentes
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Vermelho");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Prisma", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Chevrolet", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Belo Horizonte");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Minas Gerais", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Estados", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.btn_adcEstado = new System.Windows.Forms.Button();
            this.btn_removerEstado = new System.Windows.Forms.Button();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.btn_adcCidade = new System.Windows.Forms.Button();
            this.btn_removerCidade = new System.Windows.Forms.Button();
            this.tb_selecionado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(12, 91);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "vermelho";
            treeNode1.Text = "Vermelho";
            treeNode2.Name = "prisma";
            treeNode2.Text = "Prisma";
            treeNode3.BackColor = System.Drawing.Color.White;
            treeNode3.ForeColor = System.Drawing.Color.Black;
            treeNode3.Name = "chevrolet";
            treeNode3.Text = "Chevrolet";
            treeNode4.Name = "bh";
            treeNode4.Text = "Belo Horizonte";
            treeNode5.Name = "minasgerais";
            treeNode5.Text = "Minas Gerais";
            treeNode6.Name = "estados";
            treeNode6.Text = "Estados";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(459, 213);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tb_estado
            // 
            this.tb_estado.Location = new System.Drawing.Point(16, 12);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(97, 20);
            this.tb_estado.TabIndex = 1;
            // 
            // btn_adcEstado
            // 
            this.btn_adcEstado.Location = new System.Drawing.Point(119, 12);
            this.btn_adcEstado.Name = "btn_adcEstado";
            this.btn_adcEstado.Size = new System.Drawing.Size(173, 20);
            this.btn_adcEstado.TabIndex = 2;
            this.btn_adcEstado.Text = "Adicionar Estado";
            this.btn_adcEstado.UseVisualStyleBackColor = true;
            this.btn_adcEstado.Click += new System.EventHandler(this.btn_adcEstado_Click);
            // 
            // btn_removerEstado
            // 
            this.btn_removerEstado.Location = new System.Drawing.Point(298, 12);
            this.btn_removerEstado.Name = "btn_removerEstado";
            this.btn_removerEstado.Size = new System.Drawing.Size(173, 20);
            this.btn_removerEstado.TabIndex = 3;
            this.btn_removerEstado.Text = "Remover Estado";
            this.btn_removerEstado.UseVisualStyleBackColor = true;
            this.btn_removerEstado.Click += new System.EventHandler(this.btn_removerEstado_Click);
            // 
            // tb_cidade
            // 
            this.tb_cidade.Location = new System.Drawing.Point(16, 38);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(97, 20);
            this.tb_cidade.TabIndex = 4;
            // 
            // btn_adcCidade
            // 
            this.btn_adcCidade.Location = new System.Drawing.Point(119, 38);
            this.btn_adcCidade.Name = "btn_adcCidade";
            this.btn_adcCidade.Size = new System.Drawing.Size(173, 20);
            this.btn_adcCidade.TabIndex = 5;
            this.btn_adcCidade.Text = "Adicionar Cidade";
            this.btn_adcCidade.UseVisualStyleBackColor = true;
            this.btn_adcCidade.Click += new System.EventHandler(this.btn_adcCidade_Click);
            // 
            // btn_removerCidade
            // 
            this.btn_removerCidade.Location = new System.Drawing.Point(298, 38);
            this.btn_removerCidade.Name = "btn_removerCidade";
            this.btn_removerCidade.Size = new System.Drawing.Size(173, 20);
            this.btn_removerCidade.TabIndex = 6;
            this.btn_removerCidade.Text = "Remover Cidade";
            this.btn_removerCidade.UseVisualStyleBackColor = true;
            this.btn_removerCidade.Click += new System.EventHandler(this.btn_removerCidade_Click);
            // 
            // tb_selecionado
            // 
            this.tb_selecionado.Location = new System.Drawing.Point(119, 65);
            this.tb_selecionado.Name = "tb_selecionado";
            this.tb_selecionado.Size = new System.Drawing.Size(352, 20);
            this.tb_selecionado.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecionado:";
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_selecionado);
            this.Controls.Add(this.btn_removerCidade);
            this.Controls.Add(this.btn_adcCidade);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.btn_removerEstado);
            this.Controls.Add(this.btn_adcEstado);
            this.Controls.Add(this.tb_estado);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_TreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tree View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.Button btn_adcEstado;
        private System.Windows.Forms.Button btn_removerEstado;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.Button btn_adcCidade;
        private System.Windows.Forms.Button btn_removerCidade;
        private System.Windows.Forms.TextBox tb_selecionado;
        private System.Windows.Forms.Label label1;
    }
}