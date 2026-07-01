using Erbatab.Shared.ResultPattern;
using Identity.Application.DTOs.TokenDto;

namespace Identity.Application.Interfaces
{
    public interface IAuthService
    {
        Task<DataResult<TokenResultDto>> LoginAsync(string email, string pw);
        Task<DataResult<TokenResultDto>> LogoutAsync(string email, string pw);
        Task<Result> LoginWithRefreshToken(string refreshToken);
    }
}
