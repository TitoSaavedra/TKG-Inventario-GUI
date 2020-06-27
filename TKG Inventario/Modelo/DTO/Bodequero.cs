using System;
using System.Collections.Generic;
using System.Text;

namespace TKG_Inventario.DTO
{
    public class Bodequero: Cuenta
    {
        public Bodequero(int idUsuario) : base(idUsuario)
        {
            base.IdUsuario = idUsuario;
        }


        public Bodequero(int idUsuario, string rut, string nombre, string correo, string nomUsuario, string contrasena, string estado, int idTipoUsuario)
            : base(idUsuario, rut, nombre, correo, nomUsuario, contrasena, estado, idTipoUsuario)
        {
            base.IdUsuario = idUsuario;
            base.Rut = rut;
            base.Nombre = nombre;
            base.Correo = correo;
            base.NomUsuario = nomUsuario;
            base.Contrasena = contrasena;
            base.Estado = estado;
            base.IdTipoUsuario = idTipoUsuario;
        }
    }
}
