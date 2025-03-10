using Microsoft.EntityFrameworkCore;
using Segundo_parcial_Josmeyly.Models;
using System.Collections.Generic;

namespace Segundo_parcial_Josmeyly.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public virtual DbSet<Modelo> Modelo { get; set; }

    }
}