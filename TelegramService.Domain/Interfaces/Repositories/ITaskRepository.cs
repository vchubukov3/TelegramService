using Microsoft.EntityFrameworkCore;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface ITaskRepository
{
    Task<IEnumerable<Entities.Task>> GetAllAsync();

    Task<Entities.Task> GetByIdAsync();

    Task AddAsync();

    Task UpdateAsync();

    Task DeleteAsync();
}