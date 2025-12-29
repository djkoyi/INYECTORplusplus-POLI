using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INYECTOR.clases;
namespace INYECTOR.clases
{
    internal class autenticar
    {
        public static bool Autenticar(string usuario, string password)
        {
            // consulta a la base de datos
            string sql = "SELECT COUNT(*)\r\nFROM Usuario\r\nWHERE usuario = @usuario AND pass = @pass";

            // cadena conexión
            using (SqlConnection conn = new SqlConnection("Server=PC963446;Initial Catalog=informes;Persist Security Info=True;User " +
            "ID=SoporteVeraguas;Password=sqlveraguas;Encrypt=False"))
            {
                conn.Open(); // abrimos conexion

                SqlCommand cmd = new SqlCommand(sql, conn); // ejecutamos la instruccion
                cmd.Parameters.AddWithValue("@usuario", usuario); // enviamos los parametros
                cmd.Parameters.AddWithValue("@pass", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar()); // devuelve la fila afectada

                if (count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

    }
}
