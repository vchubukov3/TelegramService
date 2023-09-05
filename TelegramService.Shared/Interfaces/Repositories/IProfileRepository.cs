using TelegramService.Shared.DTO;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface IProfileRepository
{
    Task<IEnumerable<ProfileDto>> GetAllAsync();

    Task<ProfileDto> GetByGuidAsync();

    Task AddAsync();

    Task UpdateAsync();

    Task DeleteAsync();
}