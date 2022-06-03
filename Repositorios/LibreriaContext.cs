using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;

namespace Repositorios
{
    public class LibreriaContext: DbContext
    {
        public DbSet<Compra> Compras { get; set; }
        public DbSet<FichaCuidados> Fichas { get; set; }
        public DbSet<Importada> Importadas { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Planta> Plantas { get; set; }
        public DbSet<Plaza> Plazas { get; set; }
        public DbSet<Tasas> Tasas { get; set; }
        public DbSet<TipoPlanta> TiposPlantas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<CompraUsuario> ComprasUsuarios { get; set; }

        public LibreriaContext(DbContextOptions<LibreriaContext> opciones) : base(opciones)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API PARA CONFIGURAR COSAS

            modelBuilder.Entity<Compra>().HasMany(i => i.Items).WithOne(i => i.Compra);
            modelBuilder.Entity<Planta>().HasMany(i => i.Items).WithOne(i => i.Planta);
            //modelBuilder.Entity<Item>().HasKey(i => new { i.CompraId, i.PlantaId });
            modelBuilder.Entity<Item>().Property(i => i.Id).ValueGeneratedOnAdd();//Le decimos que sea identity

            modelBuilder.Entity<Compra>().HasMany(cu => cu.ComprasUsuarios).WithOne(cu => cu.Compra);
            modelBuilder.Entity<Usuario>().HasMany(cu => cu.ComprasUsuarios).WithOne(cu => cu.Usuario);
            //modelBuilder.Entity<CompraUsuario>().HasKey(cu => new { cu.CompraId, cu.UsuarioId });
            modelBuilder.Entity<CompraUsuario>().Property(cu => cu.Id).ValueGeneratedOnAdd();
            base.OnModelCreating(modelBuilder);

        }



    }
}
