using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoFinal
{
    public class BaseDatos
    {
        readonly string cadena = "Data Source=DESKTOP-U0I84OT\\SQLEXPRESS; Initial Catalog=TICKETS; Integrated Security=True";

        public bool ValidarUsuario(string codigo, string clave)
        {
            bool EsUsuarioValido = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT 1 FROM USUARIOS WHERE CODIGO = @Codigo AND CLAVE = @Clave; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();

                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 30).Value = clave;

                        EsUsuarioValido = Convert.ToBoolean(comando.ExecuteScalar());
                    }
                }
            }
            catch (Exception)
            {

            }

            return EsUsuarioValido;

        }


    }
}
