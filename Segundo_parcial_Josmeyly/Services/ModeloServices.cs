using System.Linq.Expressions;
using Segundo_parcial_Josmeyly.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Segundo_parcial_Josmeyly.DAL;

namespace Segundo_parcial_Josmeyly.Services
{
   
        public class ModeloServices(IDbContextFactory<Contexto> DbFactory)
        {
            private async Task<bool> Existe(int Id)
            {
            return true;
            }

            private async Task<bool> Insertar(Encuesta modelo)
            {
            return true;
            }

            private async Task<bool> Modificar(Encuesta modelo)
            {
            return true;
            }

            public async Task<bool> Guardar(Encuesta modelo)
            {
            return true;
            }

           public async Task<Encuesta> Buscar(int Id)
           {
            
           }

            public async Task<bool> Eliminar(int modeloId)
            {
            return true;
            }

            public async Task<List<Encuesta>> GetList(Expression<Func<Encuesta, bool>> criterio)
            {
            
            }
           public async Task<List<Encuesta>> GetModelo(int modeloId)
           {
            
           }
            public async Task<Encuesta?> BuscarModelo(int modeloid)
            {
            
            }
        }


    
}
