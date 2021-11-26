using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RESIDENCIAV1
{
    public partial class Memorama : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        int FilasColumnas = 4;
        int Movimientos = 0;
        int CartasVolteadas = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual = 0;

        public Memorama()
        {
            InitializeComponent();
            IniciarPartida();
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public void IniciarPartida()
        {
            timer1.Enabled = false;
            timer1.Stop();
            label2.Text = "0";
            CartasVolteadas = 0;
            Movimientos = 0;
            PanelJuego.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();

            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }

            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());

            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }

            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = FilasColumnas;
            tablaPanel.ColumnCount = FilasColumnas;

            for (int i = 0; i < FilasColumnas; i++)
            {
                var Porcentaje = 150f / (float)FilasColumnas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }

            int contadorFichas = 1;

            for (var i = 0; i < FilasColumnas; i++)
            {
                for (var j = 0; j < FilasColumnas; j++)
                {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.Estrella;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += btnCarta_Click;
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;
                }
            }

            tablaPanel.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(tablaPanel);
        }
        
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            
            /*lbltime.Text = null;
            cronometro.Reset();*/
            

        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            
            Movimientos++;
            label2.Text = Convert.ToString(Movimientos);
            var CartasSeleccionadasUsuario = (PictureBox)sender;
            CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
            CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual);
            CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
            
            // 2 Veces se realizo el evento del click
            if (CartasSeleccionadas.Count == 2)
            {
                CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                cronometro.Start();
                CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);
                
                if (Carta1 != Carta2)
                {
                    timer1.Enabled = true;
                    timer1.Start();
         
                }

                else
                {
                    CartasVolteadas++;
                    if (CartasVolteadas > 7)
                    {
                        cronometro.Stop();
                        MessageBox.Show("El juego terminó " + lbltime.Text);
                    
                    }

                    CartaTemporal1.Enabled = false;
                    CartaTemporal2.Enabled = false;
                    CartasSeleccionadas.Clear();
                }
            }
        }

        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(200, 100);

            switch (NumeroImagen)
            {
                case 0:
                    TmpImg = Properties.Resources.img8;
                    break;
                default:
                    TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + NumeroImagen);
                    break;
            }

            return TmpImg;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                CartaTemporal1.Image = Properties.Resources.Estrella;
                CartaTemporal2.Image = Properties.Resources.Estrella;
                CartasSeleccionadas.Clear();
                TiempoVirarCarta = 0;
                timer1.Stop();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //CRONOMETRO 
        Stopwatch cronometro = new Stopwatch();
        int seg;
        int min;

        private void btniniciar_Click(object sender, EventArgs e)
        {
            
            timer2.Enabled = true;
            cronometro.Start();
            btniniciar.Enabled = true;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbltime.Text = String.Format("{0:00}:{1:00}", cronometro.Elapsed.Minutes, cronometro.Elapsed.Seconds );

        }

        private void btnReiniciar_Click_1(object sender, EventArgs e)
        {
            IniciarPartida();
            lbltime.Text = null;
            cronometro.Reset();
        }
    }
}
 

