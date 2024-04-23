using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Chatarra
{
 
        internal class Conexcion
        {
            // Propiedad que devuelve la conexión
            public SqlConnection ObtenerConexion()
            {
                return new SqlConnection("server = LAPTOP-UME3LS19 ; database = EMPRESA ; Integrated Security=True");
            }
        }

}
