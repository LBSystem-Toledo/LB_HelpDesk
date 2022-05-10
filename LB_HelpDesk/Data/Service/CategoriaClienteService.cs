using LB_HelpDesk.Data.DTO;
using LB_HelpDesk.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace LB_HelpDesk.Data.Service
{
    public class CategoriaClienteService: ICategoriaClienteService
    {
        readonly SqlDbContext _db;
        public CategoriaClienteService(SqlDbContext db) { _db = db; }

        public async Task DeleteAsync(CategoriaCliente categoria)
        {
            _db.CategoriasCliente.Remove(categoria);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoriaCliente>> GetAsync(string DsCategoria = "")
        {
            IQueryable<CategoriaCliente> query = _db.CategoriasCliente;
            if (!string.IsNullOrWhiteSpace(DsCategoria))
                query.Where(x => x.DsCategoria.Equals(DsCategoria));
            return await query.ToListAsync();
        }

        public async Task<CategoriaCliente?> GetByIdAsync(int id)
        {
            return await _db.CategoriasCliente.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<CategoriaCliente> InsertAsync(CategoriaCliente categoria)
        {
            _db.CategoriasCliente.Add(categoria);
            await _db.SaveChangesAsync();
            return categoria;
        }

        public async Task UpdateAsync(CategoriaCliente categoria)
        {
            _db.CategoriasCliente.Update(categoria);
            await _db.SaveChangesAsync();
        }
    }
}
