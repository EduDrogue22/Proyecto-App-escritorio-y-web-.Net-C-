﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Conexion.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SERVICIO_LIMPIEZAEntities : DbContext
    {
        public SERVICIO_LIMPIEZAEntities()
            : base("name=SERVICIO_LIMPIEZAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Calificacion_de_servicio> Calificacion_de_servicio { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<Distrito> Distrito { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Producto_por_compra> Producto_por_compra { get; set; }
        public virtual DbSet<Producto_por_servicio> Producto_por_servicio { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Proveedor_por_producto> Proveedor_por_producto { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<Solicitud> Solicitud { get; set; }
        public virtual DbSet<Trabajador> Trabajador { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}
