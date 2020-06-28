using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKG_Inventario.Modelo.DTO;

namespace TKG_Inventario.Modelo.DAL
{
    public class GestorAuditoria
    {
        public void IngresarAuditoria(int tabla,int sqlConsulta,Auditoria audit)
        {
            string nomTabla = "", sqlAccion = "";
            switch (tabla)
            {
                case 1:
                    nomTabla = "Usuario";
                    break;                
                case 2:
                    nomTabla = "Compra";
                    break;                
                case 3:
                    nomTabla = "Producto_has_compra";
                    break;                
                case 4:
                    nomTabla = "Producto";
                    break;                
                case 5:
                    nomTabla = "FamiliaProducto";
                    break;               
            }
            switch (sqlConsulta)
            {
                case 1:
                    sqlAccion = "Insert";
                    break;
                case 2:
                    sqlAccion = "Update";
                    break;
                case 3:
                    sqlAccion = "Delete";
                    break;
            }
            audit.Accion= nomTabla+" "+sqlAccion;
            string fecha = audit.Fecha.ToString("yyyy-MM-dd");
            ConexionMysql cone = new ConexionMysql();
            cone.conectar().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO auditor (idAuditor, fecha, hora, accion, usuarioIdUsuario) " +
                    "VALUES (0, @fecha, @hora, @accion, @idUsu)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@fecha", MySqlDbType.VarChar).Value = fecha;
                cmd.Parameters.Add("@hora", MySqlDbType.VarChar).Value = audit.Hora;
                cmd.Parameters.Add("@accion", MySqlDbType.VarChar).Value = audit.Accion;
                cmd.Parameters.Add("@idUsu", MySqlDbType.VarChar).Value = audit.UsuarioIdUsuario;
                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }

        public void IngresarAuditoria(Auditoria audit)
        {
            string fecha = audit.Fecha.ToString("yyyy-MM-dd");
            ConexionMysql cone = new ConexionMysql();
            cone.conectar().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO auditor (idAuditor, fecha, hora, accion, usuarioIdUsuario) " +
                    "VALUES (0, @fecha, @hora, @accion, @idUsu)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@fecha", MySqlDbType.VarChar).Value = fecha;
                cmd.Parameters.Add("@hora", MySqlDbType.VarChar).Value = audit.Hora;
                cmd.Parameters.Add("@accion", MySqlDbType.VarChar).Value = audit.Accion;
                cmd.Parameters.Add("@idUsu", MySqlDbType.VarChar).Value = audit.UsuarioIdUsuario;
                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        public void MostrarAuditoria()
        {
            ConexionMysql cone = new ConexionMysql();
            dt.Clear();
            string sql = "SELECT auditor.idAuditor,auditor.fecha,cast(auditor.hora as varchar(7)) as hora,auditor.accion,usuario.usuario,usuario.rutUsuario FROM auditor,usuario WHERE auditor.usuarioIdUsuario=usuario.idUsuario";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }

        public void FiltrarFechaAudit(DateTime date)
        {
            string fecha = date.ToString("yyyy-MM-dd");
            ConexionMysql cone = new ConexionMysql();
            dt.Clear();
            string sql = "SELECT auditor.idAuditor,auditor.fecha,cast(auditor.hora as varchar(7)) as hora,auditor.accion,usuario.usuario,usuario.rutUsuario FROM auditor,usuario WHERE auditor.usuarioIdUsuario=usuario.idUsuario and fecha>='"+fecha+"'";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
