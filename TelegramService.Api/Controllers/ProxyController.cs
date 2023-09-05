using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TelegramService.Domain.Interfaces.Repositories;
using TelegramService.Shared.DTO;

namespace TelegramService.Api.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ProxyController : ControllerBase
{
    private readonly IProxyRepository _proxyRepository;

    public ProxyController(IProxyRepository proxyRepository)
    {
        _proxyRepository = proxyRepository;
    }
    
    [HttpPost("add")]
    public async Task<IActionResult> AddProxy([FromBody] ProxyDto proxyDto)
    {
        await _proxyRepository.AddAsync(proxyDto);
        await _proxyRepository.SaveChangesAsync();
        
        return Ok();
    }
    
    [HttpPost("Check")]
    public async Task<IActionResult> CheckProxy(ProxyDto proxyDto)
    {
        return Ok();
    }
    
    [HttpPost("Delete")]
    public async Task<IActionResult> DeleteProxy(ProxyDto proxyDto)
    {
        return Ok();
    }
}