using LB_HelpDesk.Data.DTO;

namespace LB_HelpDesk.Data.Interface
{
    public interface ICategoriaClienteService
    {
        Task<IEnumerable<CategoriaCliente>> GetAsync(string DsCategoria = "");
        Task<CategoriaCliente?> GetByIdAsync(int id);
        Task<CategoriaCliente> InsertAsync(CategoriaCliente categoria);
        Task UpdateAsync(CategoriaCliente categoria);
        Task DeleteAsync(CategoriaCliente categoria);
    }
}
