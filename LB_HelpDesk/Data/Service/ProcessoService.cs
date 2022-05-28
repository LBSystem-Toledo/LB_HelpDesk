using LB_HelpDesk.Data.DTO;
using LB_HelpDesk.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace LB_HelpDesk.Data.Service
{
    public class ProcessoService : IProcessoService
    {
        readonly SqlDbContext _db;
        public ProcessoService(SqlDbContext db) { _db = db; }

        public async Task DeleteAsync(Processo processo)
        {
            _db.Processos.Remove(processo);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Processo>> GetAsync(string DsProcesso = "")
        {
            IQueryable<Processo> query = _db.Processos;
            if (!string.IsNullOrWhiteSpace(DsProcesso))
                query = query.Where(x => x.DsProcesso.Contains(DsProcesso));
            return await query.ToListAsync();
        }

        public Task<IEnumerable<Processo>> GetAsync(string DsProcesso = "", string Complemento = "")
        {
            throw new NotImplementedException();
        }

        public async Task<Processo?> GetByIdAsync(int Id)
        {
            return await _db.Processos.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<Processo> InsertAsync(Processo processo)
        {
            _db.Processos.Add(processo);
            await _db.SaveChangesAsync();
            return processo;
        }

        public async Task UpdateAsync(Processo processo)
        {
            _db.Processos.Update(processo);
            await _db.SaveChangesAsync();
        }
    }
}