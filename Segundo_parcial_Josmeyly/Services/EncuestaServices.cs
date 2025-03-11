using System.Linq.Expressions;
using Segundo_parcial_Josmeyly.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Segundo_parcial_Josmeyly.DAL;
using System.Diagnostics.Eventing.Reader;

namespace Segundo_parcial_Josmeyly.Services
{

    public class EncuestaServices(IDbContextFactory<Contexto> DbFactory)
    {
        private async Task<bool> Existe(int encuestaId)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Encuesta
                .AnyAsync(e => e.EncuestaId == encuestaId);

        }

        private async Task<bool> Insertar(Encuesta encuesta)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            contexto.Encuesta.Add(encuesta);
            foreach (var dEncuesta in encuesta.DetalleCiudad)
            {
                contexto.DetalleCuidad.Add(dEncuesta);
            }
            return await contexto.SaveChangesAsync() > 0;
        }


        private async Task<bool> Modificar(Encuesta encuesta)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            contexto.Update(encuesta);
            return await contexto
                .SaveChangesAsync() > 0;

        }

        public async Task<bool> Guardar(Encuesta encuesta)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            contexto.Update(encuesta);
            return await contexto.SaveChangesAsync() > 0;

        }

        public async Task<Encuesta> Buscar(int encuestaId)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Encuesta.Include(c => c.Ciudades)
                .Include(d => d.DetalleCiudad)
                .FirstOrDefaultAsync(e => e.EncuestaId == encuestaId);
        }

        public async Task<bool> Eliminar(int encuestaId)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Encuesta
                .Where(e => e.EncuestaId == encuestaId)
                .ExecuteDeleteAsync() > 0;

        }

        public async Task<List<Encuesta>> GetList(Expression<Func<Encuesta, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Encuesta
                .Include(c => c.Ciudades)
                .Include(d => d.DetalleCiudad)
                .Where(criterio)
                .AsNoTracking()
                .ToListAsync();

        }
        public async Task<List<Encuesta>> GetEncuesta(int ciudadId)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Encuesta
                .Include(c =>c.Ciudades)
                .Include(d => d.DetalleCiudad)
                .AsNoTracking()
                .ToListAsync();

        }
        public async Task<List<Encuesta>> Listar(Expression<Func<Encuesta, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Encuesta
                .Include (c => c.Ciudades)
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<Encuesta?> BuscarEncuesta(int id)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Encuesta.
                Include(c => c.Ciudades)
                .FirstOrDefaultAsync(c => c.CiudadesId == id);
        }

        public async Task<bool> ExisteEncuesta(int EncuestaId, string Asignatura)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Encuesta
                .AnyAsync(e => e.EncuestaId != EncuestaId &&
                e.Asignatura.ToLower().Equals(Asignatura.ToLower()));
        }

    }

}
    

