using Erbatab.Shared.ResultPattern;

namespace Identity.Application.Interfaces
{
    public interface IUserService
    {
        Task<Result> RegisterUserAsync();
        string HashPassword(string password);
        bool VerifyPassword(string password, string passwordHash);
    }
}
