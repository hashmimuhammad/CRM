using Microsoft.AspNetCore.Identity;
using Dashboard.Common.Dtos;

namespace Dashboard.Api.Service
{ 
public interface IAuthService
 {
    Task RegisterAsync(RegisterDto dto);
    Task<AuthResponseDto> LoginAsync(LoginDto dto);
 
 
  }

}
