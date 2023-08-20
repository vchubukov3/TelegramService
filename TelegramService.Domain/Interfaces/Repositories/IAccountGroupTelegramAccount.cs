using TelegramService.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface IAccountGroupTelegramAccount
{
    Task<IEnumerable<AccountGroupTelegramAccount>> GetAllAsync();

    Task<AccountGroupTelegramAccount> GetByIdAsync();

    Task AddAsync();

    Task UpdateAsync();

    Task DeleteAsync();
}