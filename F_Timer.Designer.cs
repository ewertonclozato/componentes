namespace Componentes
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciar_t1 = new System.Windows.Forms.Button();
            this.btn_parar_t1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reiniciar_t1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciar_carro = new System.Windows.Forms.Button();
            this.btn_parar_carro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_iniciar_t1
            // 
            this.btn_iniciar_t1.Location = new System.Drawing.Point(12, 12);
            this.btn_iniciar_t1.Name = "btn_iniciar_t1";
            this.btn_iniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar_t1.TabIndex = 0;
            this.btn_iniciar_t1.Text = "INICIAR";
            this.btn_iniciar_t1.UseVisualStyleBackColor = true;
            this.btn_iniciar_t1.Click += new System.EventHandler(this.btn_iniciar_t1_Click);
            // 
            // btn_parar_t1
            // 
            this.btn_parar_t1.Location = new System.Drawing.Point(93, 12);
            this.btn_parar_t1.Name = "btn_parar_t1";
            this.btn_parar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_parar_t1.TabIndex = 1;
            this.btn_parar_t1.Text = "PARAR";
            this.btn_parar_t1.UseVisualStyleBackColor = true;
            this.btn_parar_t1.Click += new System.EventHandler(this.btn_parar_t1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btn_reiniciar_t1
            // 
            this.btn_reiniciar_t1.Location = new System.Drawing.Point(174, 12);
            this.btn_reiniciar_t1.Name = "btn_reiniciar_t1";
            this.btn_reiniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_reiniciar_t1.TabIndex = 3;
            this.btn_reiniciar_t1.Text = "REINICIAR";
            this.btn_reiniciar_t1.UseVisualStyleBackColor = true;
            this.btn_reiniciar_t1.Click += new System.EventHandler(this.btn_reiniciar_t1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Componentes.Properties.Resources.carro;
            this.pictureBox1.Location = new System.Drawing.Point(579, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btn_iniciar_carro
            // 
            this.btn_iniciar_carro.Location = new System.Drawing.Point(12, 82);
            this.btn_iniciar_carro.Name = "btn_iniciar_carro";
            this.btn_iniciar_carro.Size = new System.Drawing.Size(138, 23);
            this.btn_iniciar_carro.TabIndex = 5;
            this.btn_iniciar_carro.Text = "INICIAR CARRO";
            this.btn_iniciar_carro.UseVisualStyleBackColor = true;
            this.btn_iniciar_carro.Click += new System.EventHandler(this.btn_iniciar_carro_Click);
            // 
            // btn_parar_carro
            // 
            this.btn_parar_carro.Location = new System.Drawing.Point(156, 82);
            this.btn_parar_carro.Name = "btn_parar_carro";
            this.btn_parar_carro.Size = new System.Drawing.Size(138, 23);
            this.btn_parar_carro.TabIndex = 6;
            this.btn_parar_carro.Text = "PARAR CARRO";
            this.btn_parar_carro.UseVisualStyleBackColor = true;
            this.btn_parar_carro.Click += new System.EventHandler(this.btn_parar_carro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "574 * 12";
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_parar_carro);
            this.Controls.Add(this.btn_iniciar_carro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_reiniciar_t1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parar_t1);
            this.Controls.Add(this.btn_iniciar_t1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciar_t1;
        private System.Windows.Forms.Button btn_parar_t1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reiniciar_t1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_iniciar_carro;
        private System.Windows.Forms.Button btn_parar_carro;
        private System.Windows.Forms.Label label2;
    }
}