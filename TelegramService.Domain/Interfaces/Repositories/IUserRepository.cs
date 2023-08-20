using TelegramService.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllAsync();

    Task<User> GetByIdAsync();

    Task AddAsync();

    Task UpdateAsync();

    Task DeleteAsync();

}