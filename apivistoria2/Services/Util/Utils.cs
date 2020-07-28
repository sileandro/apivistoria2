using apivistoria2.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace apivistoria2.Services.Util
{
    public static class Utils
    {
        public static string PasswordEncrypt(string senha)
        {
            var sha1 = System.Security.Cryptography.SHA1.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(senha);
            return Convert.ToBase64String(sha1.ComputeHash(bytes));
        }

        public static string GenerateToken(TblUsuario user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor();
            ///{
            var teste = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.SerialNumber, user.Cpf),
                    new Claim(ClaimTypes.Name, user.CpfNavigation.Nome),
                    new Claim(ClaimTypes.Email, user.CpfNavigation.Email),
                    new Claim(ClaimTypes.Role, user.Perfil)
                });
            tokenDescriptor.Subject = teste;
            tokenDescriptor.Expires = DateTime.UtcNow.AddHours(2);
            tokenDescriptor.SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);
            //};
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
