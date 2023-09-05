using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TelegramService.Infrastructure.Data;
using TelegramService.Infrastructure.Data.Models;
using TelegramService.Shared.DTO;
using TelegramService.Shared.Interfaces.Repositories;

namespace TelegramService.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationContext _context;
    
    public UserRepository(ApplicationContext context)
    {
        _context = context;
    }
    
    public Task<IEnumerable<UserDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> GetByGuidAsync(UserDto userDto)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDto> GetByEmailAsync(string email)
    {
        var excitedUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        
        if (excitedUser == null)
        {
            return null;
        }
        
        return ConvertToDto(excitedUser);
    }
    public async Task AddAsync(UserDto userDto)
    {
        var config = new MapperConfiguration(cfg =>
        {
             cfg.CreateMap<UserDto, User>();
        });

        var mapper = config.CreateMapper();
        var user1 = mapper.Map<User>(userDto);
        
        _context.Users.Add(user1);
    }

    public async Task UpdateAsync(UserDto userDto)
    {
        throw new NotImplementedException();
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    
    public Task DeleteAsync()
    {
        throw new NotImplementedException();
    }
    
    private UserDto ConvertToDto(User user)
    {
        if (user == null)
        {
            throw new ArgumentNullException(nameof(user));
        }

        var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<User, UserDto>());

        var mapper = config.CreateMapper();
        return mapper.Map<UserDto>(user);
        // return new UserDto
        // {
        //     Id = user.Id,
        //     Email = user.Email,
        //     
        //     Name = user.Name,
        //     CreatedOn = user.CreatedOn,
        //     PasswordHash = user.PasswordHash,
        //     //Salt = user.Salt,
        //     UpdatedOn = user.UpdatedOn
        // };
    }
}