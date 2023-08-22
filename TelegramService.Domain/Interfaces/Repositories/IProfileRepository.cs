using Microsoft.EntityFrameworkCore;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface IProfileRepository
{
    Task<IEnumerable<Entities.ProfileDto>> GetAllAsync();

    Task<Entities.ProfileDto> GetByGuidAsync();

    Task AddAsync();

    Task UpdateAsync();

    Task DeleteAsync();
}