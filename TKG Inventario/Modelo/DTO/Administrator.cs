using System;

namespace TKG_Inventario.DTO
{
    public class Administrator : Cuenta
    {

        private DateTime fechaInicioTrabajo;

        public Administrator(string nomUsuario) : base(nomUsuario)
        {
            base.Nombre = nomUsuario;
        }

        public Administrator(string nomUsuario,DateTime fechaInicioTrabajo) : base(nomUsuario)
        {
            base.NomUsuario=nomUsuario;
            this.fechaInicioTrabajo = fechaInicioTrabajo;
        }

        public Administrator(string rut, string nombre, string apellidoPaterno, string apellidoMaterno, string correo, int telefono, string nomUsuario, string contrasena, DateTime fechaNacimiento, int estado, DateTime fechaInicioTrabajo)
            : base(rut, nombre, apellidoPaterno, apellidoMaterno, correo, telefono, nomUsuario, contrasena, fechaNacimiento, estado)
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
            this.FechaInicioTrabajo = fechaInicioTrabajo;
        }

        public DateTime FechaInicioTrabajo { get => fechaInicioTrabajo; set => fechaInicioTrabajo = value; }

        public override string ToString()
        {
            return base.ToString() + " Fecha inicio Trabajo : "+this.fechaInicioTrabajo;
        }
    }

}


