namespace RESIDENCIAV1
{
    partial class Memorama
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
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.btniniciar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmov = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelJuego
            // 
            this.PanelJuego.BackColor = System.Drawing.Color.White;
            this.PanelJuego.Location = new System.Drawing.Point(366, 46);
            this.PanelJuego.Margin = new System.Windows.Forms.Padding(2);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(710, 670);
            this.PanelJuego.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 41);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1018, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "_";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1046, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lbltime);
            this.panel2.Controls.Add(this.btniniciar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblmov);
            this.panel2.Controls.Add(this.btnReiniciar);
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 688);
            this.panel2.TabIndex = 30;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(87, 567);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(49, 13);
            this.lbltime.TabIndex = 48;
            this.lbltime.Text = "00:00:00";
            this.lbltime.Visible = false;
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.DarkOrange;
            this.btniniciar.FlatAppearance.BorderSize = 0;
            this.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.ForeColor = System.Drawing.Color.White;
            this.btniniciar.Location = new System.Drawing.Point(90, 427);
            this.btniniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(145, 47);
            this.btniniciar.TabIndex = 47;
            this.btniniciar.Text = "Iniciar Partida";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 359);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Movimientos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(207)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(30, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 49);
            this.label1.TabIndex = 45;
            this.label1.Text = "MEMORAMA";
            // 
            // lblmov
            // 
            this.lblmov.AutoSize = true;
            this.lblmov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblmov.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmov.Location = new System.Drawing.Point(226, 359);
            this.lblmov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmov.Name = "lblmov";
            this.lblmov.Size = new System.Drawing.Size(24, 25);
            this.lblmov.TabIndex = 44;
            this.lblmov.Text = "0";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(90, 491);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(145, 47);
            this.btnReiniciar.TabIndex = 43;
            this.btnReiniciar.Text = "Reiniciar Partida";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Memorama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Memorama";
            this.Text = "Memorama";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmov;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Timer timer2;
    }
}