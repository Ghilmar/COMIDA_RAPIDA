using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Chatarra
{
    internal class Conex2 : IDisposable
    {
        private SqlConnection conexion;

        public Conex2()
        {
            conexion = new SqlConnection("server=LAPTOP-UME3LS19; database=EMPRESA; Integrated Security=True");
        }

        public SqlConnection ObtenerConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public void Dispose()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}

