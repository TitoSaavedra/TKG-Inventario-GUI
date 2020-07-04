using Inventario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using TKG_Inventario.DTO;
using TKG_Inventario.Modelo;
using System.Windows.Forms;


namespace TKG_Inventario.DAL
{
    public class GestorProducto
    {
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable seleccionar() //ComboBox cb
        {
            //cb.Items.Clear();
            ConexionSqlServer cone = new ConexionSqlServer();
            cone.conectar().Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM FamiliaProducto";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    //while (dr.Read())
                    //{
                    //    cb.Items.Add(dr[0].ToString());
                    //    cb.Items.Add(dr[1].ToString());
                    //    cb.Items.Add(dr[2].ToString());
                    //}
                }
                cone.con.Close();
                return dt;
                //cb.Items.Insert(0, "Seleccione");
                //cb.SelectedIndex = 0;
            }
        }

        /*------------------------------ CREATE ------------------------------*/
        public void Ingresar(Producto prod)
        {
            ConexionSqlServer cone = new ConexionSqlServer();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "INSERT INTO Producto (nombre, precio, stock, estadoProducto, idFamiliaProducto) " +
                    "VALUES (@nombre,@precio,@stock,@estadoProducto,@idFamiliaProducto)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = prod.Nombre;
                cmd.Parameters.Add("@precio", SqlDbType.Int).Value = prod.Precio;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = prod.Stock;
                cmd.Parameters.Add("@estadoProducto", SqlDbType.VarChar).Value = prod.EstadoProducto;
                cmd.Parameters.Add("@idFamiliaProducto", SqlDbType.Int).Value = prod.IdFamiliaProducto;

                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }

        /*------------------------------ READ ------------------------------*/
        public void Mostrar()
        {
            ConexionSqlServer cone = new ConexionSqlServer();
            dt.Clear();
            string sql = "select idProducto as ID, nombre as Nombre, precio as Precio, stock as Stock, estadoProducto as Estado, nombreFamiliaProducto as Familia from Producto inner join FamiliaProducto on Producto.idFamiliaProducto = FamiliaProducto.idFamiliaProducto";
            SqlDataAdapter mda = new SqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }

        /*------------------------------ UPDATE ------------------------------*/
        public void Modificar(Producto prod)
        {
            ConexionSqlServer cone = new ConexionSqlServer();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.CommandText = "UPDATE Producto SET nombre = @nombre, precio = @precio, stock = @stock, estadoProducto = @estadoProducto, idFamiliaProducto = @idFamiliaProducto " +
                    "WHERE idProducto = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = prod.IdProducto;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = prod.Nombre;
                cmd.Parameters.Add("@precio", SqlDbType.Int).Value = prod.Precio;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = prod.Stock;
                cmd.Parameters.Add("@estadoProducto", SqlDbType.VarChar).Value = prod.EstadoProducto;
                cmd.Parameters.Add("@idFamiliaProducto", SqlDbType.Int).Value = prod.IdFamiliaProducto;
                
                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }

        /*------------------------------ DELETE ------------------------------*/
        public void Eliminar(Producto prod)
        {
            ConexionSqlServer cone = new ConexionSqlServer();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.CommandText = "DELETE from Producto " +
                    "Where idProducto = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = prod.IdProducto;

                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }

        /*------------------------------ FILTER ------------------------------*/
        public void Filtrar(String buscar)
        {
            ConexionSqlServer cone = new ConexionSqlServer();
            dt.Clear();

            //string sql = "select * from Producto " +
            string sql = "select idProducto as ID, nombre as Nombre, precio as Precio, stock as Stock, estadoProducto as Estado, nombreFamiliaProducto as Familia from Producto inner join FamiliaProducto on Producto.idFamiliaProducto = FamiliaProducto.idFamiliaProducto " +
                "where nombre like ('%" + buscar + "%')";
            SqlDataAdapter mda = new SqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds); dt = ds.Tables[0];
        }
    }
}