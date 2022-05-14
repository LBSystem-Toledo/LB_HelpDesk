using LB_HelpDesk.Data.DTO;

namespace LB_HelpDesk.Data.Interface
{
    public interface IModuloService
    {
        Task<IEnumerable<Modulo>> GetAsync(string DsModulo = "");
        Task<Modulo?> GetByIdAsync(int Id);
        Task<Modulo> InsertAsync(Modulo modulo);
        Task UpdateAsync(Modulo modulo);
        Task DeleteAsync(Modulo modulo);
    }
}