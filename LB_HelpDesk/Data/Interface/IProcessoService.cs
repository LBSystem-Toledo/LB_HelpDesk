using LB_HelpDesk.Data.DTO;

namespace LB_HelpDesk.Data.Interface
{
    public interface IProcessoService
    {
        Task<IEnumerable<Processo>> GetAsync(string DsProcesso = "", string Complemento = "");
        Task<Processo?> GetByIdAsync(int Id);
        Task<Processo> InsertAsync(Processo processo);
        Task UpdateAsync(Processo processo);
        Task DeleteAsync(Processo processo);
    }
}