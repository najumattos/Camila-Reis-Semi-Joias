using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Camila_Reis_Semi_Joias.API.DTOs;

namespace Camila_Reis_Semi_Joias.API.Services.Interfaces
{
    public interface IAuthService
    {
  Task<AuthResponseDto> RegisterAsync(RegisterDto registerDto);
    Task<AuthResponseDto> LoginAsync(LoginDto loginDto);
    Task<UserDto> GetUserByIdAsync(string userId);
    }
}