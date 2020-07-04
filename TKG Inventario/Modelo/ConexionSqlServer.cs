using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TKG_Inventario.Modelo
{
    class ConexionSqlServer
    {
        public SqlConnection con; 
        public SqlConnection conectar() 
        { 
            string conecta = "Data Source=(localdb)\\Servidor;Initial Catalog=TKG; Integrated Security=true"; 
            con = new SqlConnection(conecta); 
            return con; 
        }
    }
}
