using System;
using System.Data;
using System.Data.SqlClient;
using TKG_Inventario.DTO;
using TKG_Inventario.Modelo;

namespace TKG_Inventario.DAL
{
    public class GestorFamiliaProducto
    {
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        /*------------------------------ CREATE ------------------------------*/
        public void Ingresar(FamiliaProducto prod)
        {
            ConexionSqlServer cone = new ConexionSqlServer();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "INSERT INTO FamiliaProducto (nombreFamiliaProducto, estadoFamiliaProducto) " +
                    "VALUES (@nombreFamiliaProducto,@estadoFamiliaProducto)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@nombreFamiliaProducto", SqlDbType.VarChar).Value = prod.NombreFamiliaProducto;
                cmd.Parameters.Add("@estadoFamiliaProducto", SqlDbType.VarChar).Value = prod.EstadoFamiliaProducto;

                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }

        /*------------------------------ READ ------------------------------*/
        public void Mostrar()
        {
            ConexionSqlServer cone = new ConexionSqlServer();
            dt.Clear();
            string sql = "select * from FamiliaProducto";
            SqlDataAdapter mda = new SqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }

        /*------------------------------ UPDATE ------------------------------*/
        public void Modificar(FamiliaProducto prod)
        {
            ConexionSqlServer cone = new ConexionSqlServer();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.CommandText = "UPDATE FamiliaProducto SET nombreFamiliaProducto = @nombreFamiliaProducto, estadoFamiliaProducto = @estadoFamiliaProducto " +
                    "WHERE idFamiliaProducto = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = prod.IdFamiliaProducto;
                cmd.Parameters.Add("@nombreFamiliaProducto", SqlDbType.VarChar).Value = prod.NombreFamiliaProducto;
                cmd.Parameters.Add("@estadoFamiliaProducto", SqlDbType.VarChar).Value = prod.EstadoFamiliaProducto;

                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }

        /*------------------------------ DELETE ------------------------------*/
        public void Eliminar(FamiliaProducto prod)
        {
            ConexionSqlServer cone = new ConexionSqlServer();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.CommandText = "DELETE from FamiliaProducto " +
                    "Where idFamiliaProducto = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = prod.IdFamiliaProducto;

                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }

        /*------------------------------ FILTER ------------------------------*/
        public void Filtrar(String buscar)
        {
            ConexionSqlServer cone = new ConexionSqlServer();
            dt.Clear();

            string sql = "select * from FamiliaProducto " +
                "where nombreFamiliaProducto like ('%" + buscar + "%')";
            SqlDataAdapter mda = new SqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds); dt = ds.Tables[0];
        }
    }
}
