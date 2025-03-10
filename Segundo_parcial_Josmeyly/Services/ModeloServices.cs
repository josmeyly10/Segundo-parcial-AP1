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

            private async Task<bool> Insertar(Modelo modelo)
            {
            return true;
            }

            private async Task<bool> Modificar(Modelo modelo)
            {
            return true;
            }

            public async Task<bool> Guardar(Modelo modelo)
            {
            return true;
            }

           public async Task<Modelo> Buscar(int Id)
           {
            
           }

            public async Task<bool> Eliminar(int modeloId)
            {
            return true;
            }

            public async Task<List<Modelo>> GetList(Expression<Func<Modelo, bool>> criterio)
            {
            
            }
           public async Task<List<Modelo>> GetModelo(int modeloId)
           {
            
           }
            public async Task<Modelo?> BuscarModelo(int modeloid)
            {
            
            }
        }


    
}
