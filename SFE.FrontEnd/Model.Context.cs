﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFE.FrontEnd
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SFE_CostaRicaEntities2 : DbContext
    {
        public SFE_CostaRicaEntities2()
            : base("name=SFE_CostaRicaEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<facturaElectronica> facturaElectronica { get; set; }
        public virtual DbSet<Historial> Historial { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<ListaProductos> ListaProductos { get; set; }
        public virtual DbSet<Local> Local { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}