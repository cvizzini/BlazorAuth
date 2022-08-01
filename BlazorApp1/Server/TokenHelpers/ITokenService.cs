﻿using BlazorApp1.Server.Context.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BlazorApp1.Server.TokenHelpers
{
    public interface ITokenService
    {
        SigningCredentials GetSigningCredentials();
        Task<List<Claim>> GetClaims(User user);
        JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
