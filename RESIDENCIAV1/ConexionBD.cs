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
    
    public class ConexionBD
    {
        public static string Conex = Conexiones();
        public static string Conexiones()
        {


            string cs = "server=YIMQUIROZ\\SQLEXPRESS;database=Residencia_Memorama;integrated security=true;";
            return cs;

        }

        public static void InsertaHistorial(int Id_Usuario, string Tiempo, int Movimientos)
        {
            string query = "[dbo].[Insertar_Historial]";
            SqlParameter[] Par = new SqlParameter[4];
            Par[0] = new SqlParameter("@Id_Usuario", SqlDbType.Int);
            Par[0].Value = Id_Usuario;
            Par[1] = new SqlParameter("@Tiempo", SqlDbType.VarChar);
            Par[1].Value = Tiempo;
            Par[2] = new SqlParameter("@Movimientos", SqlDbType.Int);
            Par[2].Value = Movimientos;

            SqlHelper.ExecuteDataset(Conex, CommandType.StoredProcedure, query, Par);
        }

        public static DataTable Traer_IdUser(string Nombre_Usuario)
        {
            string query = "[dbo].[Traer_Usuario]";
            DataTable dtUsuario;
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@NombreUsuario", SqlDbType.VarChar);
            Par[0].Value = Nombre_Usuario;
                     
            return dtUsuario = SqlHelper.ExecuteDataset(Conex, CommandType.StoredProcedure,query,Par).Tables[0];

        }
    }
}
