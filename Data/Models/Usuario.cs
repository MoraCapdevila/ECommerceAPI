﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Venta = new HashSet<Venta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public int IdRol { get; set; }

        public virtual RolUsuario IdRolNavigation { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}