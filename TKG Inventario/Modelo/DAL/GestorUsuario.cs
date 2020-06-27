using MySql.Data.MySqlClient;
using System;
using System.Data;
using TKG_Inventario.DTO;
using TKG_Inventario.Modelo;

namespace TKG_Inventario.DAL
{
    public class GestorUsuario
    {
        /*
        public Usuario Login(Usuario usuario)
        {
            ConexionMysql cone = new ConexionMysql();
            cone.conectar().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                string sql = "select idUsuario, nombreUsuario, emailUsuario, rutUsuario, usuario, estadoUsuario, TipoUsuarioIdTipoUsuario from usuario where idUsuario=1 " +
                    "and usuario="+usuario.NomUsuario+" and clave="+usuario.Contrasena;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    usuario.IdUsuario = int.Parse(reader["idUsuario"].ToString());
                    usuario.Rut = reader["rutUsuario"].ToString();
                    usuario.Nombre = reader["nombreUsuario"].ToString();
                    usuario.NomUsuario = reader["usuario"].ToString();
                    string estado="";
                    switch (int.Parse(reader["estadoUsuario"].ToString()))
                    {
                        case 1:
                            estado = "Activo";
                            break;
                        case 2:
                            estado = "Inactivo";
                            break;
                    } 
                    usuario.Estado = estado;
                    usuario.IdTipoUsuario= int.Parse(reader["TipoUsuarioIdTipoUsuario"].ToString());
                    return usuario;
                }
            }
            return null;
        }
        */

        public void Ingresar(Usuario usu)
        {
            ConexionMysql cone = new ConexionMysql();
            cone.conectar().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO USUARIO (idUsuario, nombreUsuario, emailUsuario, rutUsuario, usuario, clave, estadoUsuario, TipoUsuarioIdTipoUsuario) " +
                    "VALUES (0, @nomUsu, @emailUsu, @rutUsu, @usu, @clave, @estadoUsu, @tipoUsuId)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@nomUsu", MySqlDbType.VarChar).Value = usu.Nombre;
                cmd.Parameters.Add("@emailUsu", MySqlDbType.VarChar).Value = usu.Correo;
                cmd.Parameters.Add("@rutUsu", MySqlDbType.VarChar).Value = usu.Rut;
                cmd.Parameters.Add("@usu", MySqlDbType.VarChar).Value = usu.NomUsuario;
                cmd.Parameters.Add("@clave", MySqlDbType.VarChar).Value = usu.Contrasena;
                cmd.Parameters.Add("@estadoUsu", MySqlDbType.VarChar).Value = usu.Estado;
                cmd.Parameters.Add("@tipoUsuId", MySqlDbType.Int32).Value = usu.IdTipoUsuario;
                cmd.ExecuteNonQuery();
                cone.con.Close();
            }

        }

        public void Modificar(Usuario usu)
        {
            ConexionMysql cone = new ConexionMysql();
            cone.conectar().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "UPDATE usuario SET nombreUsuario = @nomUsu, emailUsuario= @emailUsu, rutUsuario = @rutUsu, usuario = @usu, clave = @clave," +
                    " estadoUsuario = @estadoUsu, TipoUsuarioIdTipoUsuario = @tipoUsuId WHERE idUsuario = @idUsu";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@idUsu", MySqlDbType.Int32).Value = usu.IdUsuario;
                cmd.Parameters.Add("@nomUsu", MySqlDbType.VarChar).Value = usu.Nombre;
                cmd.Parameters.Add("@emailUsu", MySqlDbType.VarChar).Value = usu.Correo;
                cmd.Parameters.Add("@rutUsu", MySqlDbType.VarChar).Value = usu.Rut;
                cmd.Parameters.Add("@usu", MySqlDbType.VarChar).Value = usu.NomUsuario;
                cmd.Parameters.Add("@clave", MySqlDbType.VarChar).Value = usu.Contrasena;
                cmd.Parameters.Add("@estadoUsu", MySqlDbType.VarChar).Value = usu.Estado;
                cmd.Parameters.Add("@tipoUsuId", MySqlDbType.Int32).Value = usu.IdTipoUsuario;
                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        public void Mostrar()
        {

            ConexionMysql cone = new ConexionMysql();
            dt.Clear();
            string sql = "select idUsuario, nombreUsuario, emailUsuario, rutUsuario, usuario, estadoUsuario, TipoUsuarioIdTipoUsuario from usuario where idUsuario!=1";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }

        public void Filtrar(String nomUsuarioBuscar)
        {
            ConexionMysql cone = new ConexionMysql();
            dt.Clear();
            string sql = "select  idUsuario, nombreUsuario, emailUsuario, rutUsuario, usuario, estadoUsuario, TipoUsuarioIdTipoUsuario from usuario " +
                "where usuario like ('%" + nomUsuarioBuscar + "%') and idUsuario!=1";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }

        public void Eliminar(Usuario usuario)
        {
            ConexionMysql cone = new ConexionMysql();
            cone.conectar().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE from usuario Where idUsuario = @idUsuario";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@idUsuario", MySqlDbType.Int32).Value = usuario.IdUsuario;
                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }
    }
    
}
