
using LB_HelpDesk.Data.DTO;
using LB_HelpDesk.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace LB_HelpDesk.Data.Service
{
    public class ModuloService : IModuloService
    {
        readonly SqlDbContext _db;
        public ModuloService(SqlDbContext db) { _db = db; }

        public async Task DeleteAsync(Modulo modulo)
        {
            _db.Modulos.Remove(modulo);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Modulo>> GetAsync(string DsModulo = "")
        {
            IQueryable<Modulo> query = _db.Modulos;
            if(!string .IsNullOrWhiteSpace(DsModulo))
                query = query.Where(x => x.DsModulo.Contains(DsModulo));
            return await query.ToListAsync();
        }

        public async Task<Modulo?> GetByIdAsync(int Id)
        {
            return await _db.Modulos.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<Modulo> InsertAsync(Modulo modulo)
        {
            _db.Modulos.Add(modulo);
            await _db.SaveChangesAsync();
            return modulo;
        }

        public async Task UpdateAsync(Modulo modulo)
        {
            _db.Modulos.Update(modulo);
            await _db.SaveChangesAsync();
        }
    }
}
