using TelegramService.Shared.DTO;
using Task = System.Threading.Tasks.Task;

namespace TelegramService.Shared.Interfaces.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<UserDto>> GetAllAsync();

    Task<UserDto> GetByGuidAsync(UserDto userDto);

    Task<UserDto> GetByEmailAsync(string email);
    
    Task AddAsync(UserDto userDto);

    Task UpdateAsync(UserDto userDto);

    Task SaveChangesAsync();

    Task DeleteAsync();

}