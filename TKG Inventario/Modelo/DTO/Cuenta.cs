using System;
using System.Collections.Generic;
using System.Text;

namespace TKG_Inventario.DTO
{
    public class Cuenta
    {
        private string rut;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string correo;
        private int telefono;
        private string nomUsuario;
        private string contrasena;
        private DateTime fechaNacimiento;
        private int estado;

        public Cuenta(string nomUsuario)
        {
            this.nomUsuario = nomUsuario;
        }

        public Cuenta(string rut, string nombre, string apellidoPaterno, string apellidoMaterno, string correo, int telefono, string nomUsuario, string contrasena, DateTime fechaNacimiento, int estado)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.Correo = correo;
            this.Telefono = telefono;
            this.NomUsuario = nomUsuario;
            this.Contrasena = contrasena;
            this.FechaNacimiento = fechaNacimiento;
            this.Estado = estado;
        }



        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string NomUsuario { get => nomUsuario; set => nomUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Estado { get => estado; set => estado = value; }

        public override string ToString()
        {
            return "Rut : "+this.rut +" Nombre : "+this.nombre + " Apellidos : "+this.apellidoPaterno + " "+ this.ApellidoMaterno + " Fecha nacimiento : "+this.fechaNacimiento;
        }
    }
}
