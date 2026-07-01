using Erbatab.Shared.ResultPattern;
using Identity.Application.DTOs.TokenDto;
using Identity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Application.Interfaces
{
    public interface ITokenService
    {
        Task<DataResult<TokenResultDto>> GenerateAccessTokenAsync(User user);
        DataResult<string> GenerateRefreshToken();
    }
}
