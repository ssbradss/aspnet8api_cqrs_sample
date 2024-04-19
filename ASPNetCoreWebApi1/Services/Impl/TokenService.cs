using ASPNetCoreWebApi1.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualStudio.Services.WebApi.Jwt;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Authentication;

namespace ASPNetCoreWebApi1.Services.Impl
{
    public class TokenService
    {
        private readonly SigningAudienceCertificate signingAudienceCertificate;

        public TokenService()
        {
            signingAudienceCertificate = new SigningAudienceCertificate();
        }

        public string GetToken()
        {
            SecurityTokenDescriptor tokenDescriptor = GetTokenDescriptor();
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken = tokenHandler.CreateToken(tokenDescriptor);
            string token = tokenHandler.WriteToken(securityToken);

            return token;
        }

        private SecurityTokenDescriptor GetTokenDescriptor()
        {
            const int expiringDays = 7;

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddDays(expiringDays),
                SigningCredentials = signingAudienceCertificate.GetAudienceSigningKey()
            };

            return tokenDescriptor;
        }
    }
}
