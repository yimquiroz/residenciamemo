using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Librerias;

namespace RESIDENCIAV1
{
    class DL
    {
        public static string Conex = Conecciones();
        public static string Conecciones()
        {


            string cs = "Data Source=51.1.20.247;Initial Catalog=TelvistaDWH;User Id=TelvistaDWH;Password=t3lv1st4dwh;";
            return cs;

        }

        public static string InsertaHistorial(int Id_Usuario, string Tiempo, int Movimientos)
        {
            string query = "[dbo].[Insertar_Historial]";
            SqlParameter[] Par = new SqlParameter[10];
            Par[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
            Par[0].Value = Nombre;
        }
    }
}
