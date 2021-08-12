using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSFENIXGDI2.Datos
{
    class ConexionBaseDatos
    {
        public SqlConnection ObjetoConexion { get; private set; }

        public void AbrirConexion()
        {
            ObjetoConexion = new SqlConnection();

            ObjetoConexion.ConnectionString = "server=ALONSOJR;DataBase=OXFENIX;user id=Alonsojr;password = 123456";

            try
            {
                ObjetoConexion.Open();
            }
            catch
            {
                throw new Exception("Error: no se pudo establecer la conexión con la base de datos");
            }

        }

        public void CerrarConexion()
        {
            try
            {
                ObjetoConexion.Close();
            }
            catch
            {
                throw new Exception("Error: no se pudo cerrar la conexión con la base de datos");
            }
        }

        public SqlCommand obtenerComandoDeProcedimiento(string procedimiento)
        {
            SqlCommand objetoComando = new SqlCommand();
            objetoComando.CommandText = procedimiento;
            objetoComando.CommandType = CommandType.StoredProcedure;
            objetoComando.Connection = ObjetoConexion;
            return objetoComando;
        }


    }
}
