using Microsoft.EntityFrameworkCore;
using Segundo_parcial_Josmeyly.Models;
using System.Collections.Generic;

namespace Segundo_parcial_Josmeyly.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public  DbSet<Encuesta> Encuesta { get; set; }

        public  DbSet<DetalleCiudad> DetalleCiudad{ get; set; }

        public DbSet<Ciudades> Ciudades { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudades>().HasData(
                new List<Ciudades>()
                {
                new()
                {
                    CiudadesId = 1,
                    Nombres = "Villa Arriba",
                    Monto= 0,
                },
                new()
                {
                    CiudadesId = 2,
                    Nombres = "San francisco",
                    Monto= 0,
                },
                new()
                {
                    CiudadesId = 3,
                    Nombres = "San Pedro de macoris",
                    Monto= 0,
                }
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}