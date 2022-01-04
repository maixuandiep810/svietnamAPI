using System.Linq;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Security.Claims;
using System.Text;
using svietnamAPI.StartupConfiguration.AppSetting;
using svietnamAPI.Dtos.Auth;
using svietnamAPI.Helper.Exceptions;
using svietnamAPI.Dtos.ValueDtos;

namespace svietnamAPI.Helper
{
    public static class JwtHelper
    {
        public static string GenerateJwtToken(UserDto user, ServerSetting serverSetting)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(serverSetting.JwtInfo.Secret);
            var tokenDescription = new SecurityTokenDescriptor  
            {
                Subject = new ClaimsIdentity(new[] {
                    new Claim(ClaimInfo.UserId, user.UserId.ToString()),
                    new Claim(ClaimInfo.GroupCode, user.Group.Code),
                    new Claim(ClaimInfo.RoleCodes, String.Join(AuthValueConst.RoleCodesSeperator, user.Roles.Select(p => p.Code).ToArray()))
                }),
                Expires = DateTime.UtcNow.AddDays(serverSetting.JwtInfo.Expires),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescription);
            return tokenHandler.WriteToken(token);
        }

        public static ClaimsPrincipal ValidateJwtToken(string token, ServerSetting serverSetting)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(serverSetting.JwtInfo.Secret);
                var principal = tokenHandler.ValidateToken(
                    token,
                    new TokenValidationParameters
                    {
                        // b1, có kiểm tra IssuerSigningKey & cung cấp IssuerSigningKey dể  kiểm tra
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        // b2, không kiểm tra, và không cung cấp
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                        // b3, lấy thời gian hết hạn đúng y thời gian hết hạn trên token
                        ClockSkew = TimeSpan.Zero
                    },
                    out SecurityToken validatedToken
                );
                return principal;
            }
            catch (SecurityTokenValidationException ex)
            {
                throw new AppJwtTokenException(ex);
            }
            catch (SecurityTokenException ex)
            {
                throw new AppJwtTokenException(ex);
            }
            catch (System.Exception ex)
            {
                throw new AppSystemException(ex);
            }
        }
    }
}