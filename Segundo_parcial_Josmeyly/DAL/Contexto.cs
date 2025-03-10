using Microsoft.EntityFrameworkCore;
using Segundo_parcial_Josmeyly.Models;
using System.Collections.Generic;

namespace Segundo_parcial_Josmeyly.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public virtual DbSet<Encuesta> Encuesta { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudades>().HasData(
                new List<Ciudades>()
                {
                new()
                {
                    CiudadId = 1,
                    Nombres = "Villa Arriba",
                    Monto= 0,
                },
                new()
                {
                    CiudadId = 2,
                    Nombres = "San francisco",
                    Monto= 0,
                },
                new()
                {
                    CiudadId = 3,
                    Nombres = "San Pedro de macoris",
                    Monto= 0,
                }
                }
            );
            base.OnModelCreating(modelBuilder);
        }

    }
}