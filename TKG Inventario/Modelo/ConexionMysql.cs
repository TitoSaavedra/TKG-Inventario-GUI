using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKG_Inventario.Modelo
{
    public class ConexionMysql
    {
        public MySqlConnection con;

        public MySqlConnection conectar()
        {
            string host = "localhost";
            string db = "inventario";
            string user = "root";
            string clave = "";
            string conecta = "server = " + host + "; user id = " + user + "; database = " + db + "; password = " + clave;
            con = new MySqlConnection(conecta);
            return con;
        }
    }
}
