
namespace RESIDENCIAV1
{
    partial class SimonDice
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
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.lbl_puntaje = new System.Windows.Forms.Label();
            this.p_3 = new System.Windows.Forms.PictureBox();
            this.p_2 = new System.Windows.Forms.PictureBox();
            this.p_1 = new System.Windows.Forms.PictureBox();
            this.p_0 = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_0)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(42, 334);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 4;
            this.btn_iniciar.Text = "Iniciar juego";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // lbl_puntaje
            // 
            this.lbl_puntaje.AutoSize = true;
            this.lbl_puntaje.Location = new System.Drawing.Point(139, 9);
            this.lbl_puntaje.Name = "lbl_puntaje";
            this.lbl_puntaje.Size = new System.Drawing.Size(13, 13);
            this.lbl_puntaje.TabIndex = 25;
            this.lbl_puntaje.Text = "--";
            // 
            // p_3
            // 
            this.p_3.Image = global::RESIDENCIAV1.Properties.Resources._4;
            this.p_3.Location = new System.Drawing.Point(163, 178);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(133, 148);
            this.p_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_3.TabIndex = 3;
            this.p_3.TabStop = false;
            this.p_3.Click += new System.EventHandler(this.p_0_Click);
            this.p_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_3_MouseDown);
            this.p_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_3_MouseUp);
            // 
            // p_2
            // 
            this.p_2.Image = global::RESIDENCIAV1.Properties.Resources._3;
            this.p_2.Location = new System.Drawing.Point(-6, 178);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(133, 148);
            this.p_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_2.TabIndex = 2;
            this.p_2.TabStop = false;
            this.p_2.Click += new System.EventHandler(this.p_0_Click);
            this.p_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_2_MouseDown);
            this.p_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_2_MouseUp);
            // 
            // p_1
            // 
            this.p_1.Image = global::RESIDENCIAV1.Properties.Resources._2;
            this.p_1.Location = new System.Drawing.Point(163, 24);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(133, 148);
            this.p_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_1.TabIndex = 1;
            this.p_1.TabStop = false;
            this.p_1.Click += new System.EventHandler(this.p_0_Click);
            this.p_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_1_MouseDown);
            this.p_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_1_MouseUp);
            // 
            // p_0
            // 
            this.p_0.Image = global::RESIDENCIAV1.Properties.Resources._1;
            this.p_0.Location = new System.Drawing.Point(-6, 24);
            this.p_0.Name = "p_0";
            this.p_0.Size = new System.Drawing.Size(133, 148);
            this.p_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_0.TabIndex = 0;
            this.p_0.TabStop = false;
            this.p_0.Click += new System.EventHandler(this.p_0_Click);
            this.p_0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_0_MouseDown);
            this.p_0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_0_MouseUp);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(163, 334);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(145, 47);
            this.btnReiniciar.TabIndex = 44;
            this.btnReiniciar.Text = "Reiniciar Partida";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // SimonDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 392);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lbl_puntaje);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_2);
            this.Controls.Add(this.p_1);
            this.Controls.Add(this.p_0);
            this.Name = "SimonDice";
            this.Text = "SimonDice";
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p_0;
        private System.Windows.Forms.PictureBox p_1;
        private System.Windows.Forms.PictureBox p_2;
        private System.Windows.Forms.PictureBox p_3;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label lbl_puntaje;
        private System.Windows.Forms.Button btnReiniciar;
    }
}