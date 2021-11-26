using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace RESIDENCIAV1
{
    public partial class Registro : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public Registro()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        
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
        private void login()
        {
            
        }
        
        public SqlConnection conexion = new SqlConnection("server=YIMQUIROZ\\SQLEXPRESS;database=Residencia_Memorama;integrated security=true");
       

        public void txtlisto_Click(object sender, EventArgs e)
        {

            conexion.Open();
            SqlCommand  cmd = new SqlCommand ("insert into Usuarios  (Usuario,Correo,Passw,Passw1) values (@Usuario,@Correo,@Pass,@Passw1)",conexion);
            cmd.Parameters.Add("@Usuario", txtuser.Text);
            cmd.Parameters.Add("@Correo",txtemail.Text);
            cmd.Parameters.Add("@Pass", txtpass.Text);
            cmd.Parameters.Add("@Passw1", txtpass1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Exitoso");
            txtuser.Text = "";
            txtemail.Text = "";
            txtpass.Text = "";
            txtpass1.Text = "";
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Login();
            f.Show();
            this.Hide();
        }
    }
}
