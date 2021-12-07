using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace RESIDENCIAV1
{
    public partial class SimonDice : Form
    {
        int ControlSecuencia = 0;
        Random NumeroAleatorio;
        List<int> SimonDice_ = new List<int>();
        bool Hablando = false;
        public SimonDice()
        {
            InitializeComponent();
            //Inicializando boton de random
            NumeroAleatorio = new Random();
        }
        public void IniciarJuego()
        {
            Thread.Sleep(200);
            Hablando = true;
            foreach(int ParteActiva in SimonDice_)
            {
                switch (ParteActiva)
                {
                    case 0:
                        p_0.Image = Properties.Resources._1_on;
                        Thread.Sleep(200);
                        p_0.Image = Properties.Resources._1;
                        break;
                    case 1:
                        p_1.Image = Properties.Resources._2_on;
                        Thread.Sleep(200);
                        p_1.Image = Properties.Resources._2;
                        break;
                    case 2:
                        p_2.Image = Properties.Resources._3_on;
                        Thread.Sleep(200);
                        p_2.Image = Properties.Resources._3;
                        break;
                    case 3:
                        p_3.Image = Properties.Resources._4_on;
                        Thread.Sleep(200);
                        p_3.Image = Properties.Resources._4;
                        break;
                }
                Thread.Sleep(200);
            }
            Hablando = false;
        }
        public void VerificarBotonPresionado(int ValorBoton)
        {
            if (Hablando || SimonDice_.Count == 0) return;

            if (SimonDice_[ControlSecuencia] == ValorBoton) ControlSecuencia++;
            else
            {
                MessageBox.Show("Tu record Final es:" + SimonDice_.Count);
                ControlSecuencia = 0;
                SimonDice_ = new List<int>();
            }
            if (ControlSecuencia >= SimonDice_.Count)
            {
                ControlSecuencia = 0;
                SimonDice_.Add(NumeroAleatorio.Next(0, 4));
                new Thread(IniciarJuego).Start();
            }
            lbl_puntaje.Text = SimonDice_.Count.ToString();
        }
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            SimonDice_.Add(NumeroAleatorio.Next(0, 4));
            new Thread(IniciarJuego).Start();
        }

        private void p_0_Click(object sender, EventArgs e)
        {
            String Presionado = ((PictureBox)sender).Name;
            string[] NumeroBoton = Presionado.Split('_');
            VerificarBotonPresionado(Convert.ToInt32(NumeroBoton[1]));

        }

        private void p_0_MouseDown(object sender, MouseEventArgs e)
        {
            p_0.Image = Properties.Resources._1_on;
        }

        private void p_0_MouseUp(object sender, MouseEventArgs e)
        {
            p_0.Image = Properties.Resources._1;
        }

        private void p_1_MouseDown(object sender, MouseEventArgs e)
        {
            p_1.Image = Properties.Resources._2_on;
        }

        private void p_1_MouseUp(object sender, MouseEventArgs e)
        {
            p_1.Image = Properties.Resources._2;
        }

        private void p_2_MouseDown(object sender, MouseEventArgs e)
        {
            p_2.Image = Properties.Resources._3_on;
        }

        private void p_2_MouseUp(object sender, MouseEventArgs e)
        {
            p_2.Image = Properties.Resources._3;
        }

        private void p_3_MouseDown(object sender, MouseEventArgs e)
        {
            p_3.Image = Properties.Resources._4_on;
        }

        private void p_3_MouseUp(object sender, MouseEventArgs e)
        {
            p_3.Image = Properties.Resources._4;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }
    }
}
