using TelegramService.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface ITelegramAccountRepository
{
    Task<IEnumerable<TelegramAccountDto>> GetAllAsync();

    Task<TelegramAccountDto> GetByGuidAsync();

    Task AddAsync();

    Task UpdateAsync();

    Task DeleteAsync();
}