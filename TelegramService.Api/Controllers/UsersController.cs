using Microsoft.AspNetCore.Mvc;
using TelegramService.Infrastructure.Data.Models;
using TelegramService.Infrastructure.Repositories;
using TelegramService.Shared.DTO;
using TelegramService.Shared.Interfaces.Repositories;

namespace TelegramService.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UsersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserDto userDto)
    {
        var existingUserDto = await _userRepository.GetByEmailAsync(userDto.Email);

        if (existingUserDto != null)
        {
            return new JsonResult(new 
            {
                status = "error",
                message = "Пользователь с такой электронной почтой уже зарегистрирован"
            });
        }
        
        await _userRepository.AddAsync(userDto);
        await _userRepository.SaveChangesAsync();
        return new JsonResult(new 
        {
            status = "success",
            message = "Пользователь успешно зарегистрирован"
        });
    }
}