using TelegramService.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface ITelegramAccountRepository
{
    Task<IEnumerable<TelegramAccount>> GetAllAsync();

    Task<TelegramAccount> GetByIdAsync();

    Task AddAsync();

    Task UpdateAsync();

    Task DeleteAsync();
}