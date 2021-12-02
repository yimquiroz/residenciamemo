using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RESIDENCIAV1
{
    public partial class Login : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public Usuarios usuario1 = new Usuarios();

        public int usuario;

        public DataTable UserID;

        public Login()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public SqlConnection conexion = new SqlConnection("server=YIMQUIROZ\\SQLEXPRESS;database=Residencia_Memorama;integrated security=true");
        
        private void user_Enter(object sender, EventArgs e)
        {
            //creando condicion para verificar si es el usuario y se vacia
            if (usertxt.Text == "USUARIO")
            {
                usertxt.Text = "";
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            
        }

        private void registrotxt_Click(object sender, EventArgs e)
        {
            //Nuevo registro con clic
            Form formulario = new Registro();
            formulario.Show();
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
        

        public void button1_Click(object sender, EventArgs e)
        {

            UserID = ConexionBD.Traer_IdUser(usertxt.Text);
            usuario1.Id =Convert.ToInt32( UserID.Rows[0]["id"].ToString());
            conexion.Open();
            string consulta = "select * from Usuarios where Usuario='" + usertxt.Text + "'and Passw='" + psstxt.Text + "'";
            SqlCommand comando = new SqlCommand(consulta,conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            

            if (lector.HasRows==true)
            {

                

                Memorama memorama = new Memorama();
                this.Hide();
                memorama.Show();

                

            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
            conexion.Close();
        }

        private void registrotxt_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            //Instrucciones para poder recuperar la contraseña mediante gmail
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("www.gmail.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (psstxt.PasswordChar == '\0')
            {
                button3.BringToFront();
                psstxt.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (psstxt.PasswordChar == '*')
            {
                button2.BringToFront();
                psstxt.PasswordChar = '\0';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
