using TelegramService.Domain.Interfaces.Repositories;
using TelegramService.Infrastructure.Data;
using TelegramService.Infrastructure.Data.Models;
using TelegramService.Shared.DTO;
using TelegramService.Shared.Enums;

namespace TelegramService.Infrastructure.Repositories;

public class ProxyRepository : IProxyRepository
{
    private readonly ApplicationContext _context;
    
    public ProxyRepository(ApplicationContext context)
    {
        _context = context;
    }
    
    public Task<IEnumerable<ProxyDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProxyDto> GetByUserIdAsync()
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(ProxyDto proxyDto)
    {
        var proxy = new Proxy
        {
            Id = Guid.NewGuid(),
            UserId = proxyDto.UserId,//Guid.NewGuid(),//proxyDto.UserId,
            Address = proxyDto.Address,
            Port = proxyDto.Port,
            ProxyType = proxyDto.ProxyType,
            ProxyStatus = ProxyStatus.NotChecked,
            IsActivate = false,
            CreatedOn = DateTimeOffset.Now,
            UpdatedOn = DateTimeOffset.Now
        };
            
        _context.Proxies.Add(proxy);
    }

    public Task UpdateAsync(ProxyDto proxyDto)
    {
        throw new NotImplementedException();
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    
    public Task DeleteAsync(ProxyDto proxyDto)
    {
        throw new NotImplementedException();
    }

    public Task CheckStatus(ProxyDto proxyDto)
    {
        throw new NotImplementedException();
    }
}