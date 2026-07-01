using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Application.DTOs.TokenDto
{
    public class TokenResultDto
    {
        public string? AccessToken {  get; set; }
        public string? RefreshToken{  get; set; }
    }
}
