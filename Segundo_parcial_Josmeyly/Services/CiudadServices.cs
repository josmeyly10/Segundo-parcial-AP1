using System.Linq.Expressions;
using Segundo_parcial_Josmeyly.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Segundo_parcial_Josmeyly.DAL;
using System.Diagnostics.Eventing.Reader;

namespace Segundo_parcial_Josmeyly.Services
{

    public class CiudadServices(IDbContextFactory<Contexto> DbFactory)
    {

        public async Task<Ciudades> Buscar(int ciudadId)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Ciudades
               // .Include(d => d.DetalleCiudad)
                .FirstOrDefaultAsync(e => e.CiudadesId == ciudadId);
        }

        public async Task<List<Ciudades>> Listar(Expression<Func<Ciudades, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Ciudades
                .Where(criterio)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}


