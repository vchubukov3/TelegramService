using TelegramService.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<UserDto>> GetAllAsync();

    Task<UserDto> GetByGuidAsync();

    Task AddAsync();

    Task UpdateAsync();

    Task DeleteAsync();

}