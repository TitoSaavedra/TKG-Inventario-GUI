using System;
using System.Collections.Generic;
using System.Text;

namespace TKG_Inventario.DTO
{
    public class Bodequero: Cuenta
    {
        private string bodegaAcargo;
        private DateTime fechaInicioTrabajo;

        public Bodequero(string nomUsuario):base(nomUsuario)
        {
            base.NomUsuario = nomUsuario;
        }

        public Bodequero(string nomUsuario,string bodegaAcargo,DateTime fechaInicioTrabajo) : base(nomUsuario)
        {
            base.NomUsuario = nomUsuario;
            this.bodegaAcargo = bodegaAcargo;
            this.fechaInicioTrabajo = fechaInicioTrabajo;
        }

        public Bodequero(string rut, string nombre, string apellidoPaterno, string apellidoMaterno, string correo, int telefono, string nomUsuario, string contrasena, DateTime fechaNacimiento, int estado,string bodegaAcargo, DateTime fechaInicioTrabajo) : base(rut, nombre, apellidoPaterno, apellidoMaterno, correo, telefono, nomUsuario, contrasena, fechaNacimiento, estado)
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
            this.BodegaAcargo = bodegaAcargo;
            this.FechaInicioTrabajo = fechaInicioTrabajo;
        }

        public string BodegaAcargo { get => bodegaAcargo; set => bodegaAcargo = value; }
        public DateTime FechaInicioTrabajo { get => fechaInicioTrabajo; set => fechaInicioTrabajo = value; }

        public override string ToString()
        {
            return base.ToString() + "Bodega a cargo : "+this.bodegaAcargo+ " Fecha inicio trabajo : "+this.fechaInicioTrabajo;
        }
    }
}
