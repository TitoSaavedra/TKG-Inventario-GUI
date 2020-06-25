using System;
using System.Collections.Generic;
using System.Text;

namespace TKG_Inventario.DTO
{
    public class Usuario: Cuenta
    {
        public Usuario(string rut, string nombre, string apellidoPaterno, string apellidoMaterno, string correo, int telefono, string nomUsuario, string contrasena, DateTime fechaNacimiento, int estado) : base(rut,nombre,apellidoPaterno,apellidoMaterno,correo,telefono,nomUsuario,contrasena,fechaNacimiento,estado)
        {
            base.Rut = rut;
            base.Nombre = nombre;
            base.ApellidoPaterno = apellidoPaterno;
            base.ApellidoMaterno = apellidoMaterno;
            base.Correo = correo;
            base.Telefono = telefono;
            base.NomUsuario = nomUsuario;
            base.Contrasena = contrasena;
            base.FechaNacimiento = fechaNacimiento;
            base.Estado = estado;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
