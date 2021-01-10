using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WEB2020.Model;
using WEB2020.Models;

namespace WEB2020.Data
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        // AuthenticateResponse RefreshToken(string token, string ipAddress);
        bool RevokeToken(string token, string ipAddress);
        IEnumerable<Nguoidung> GetAll();
        Nguoidung GetById(string id);
    }

    public class UserService : IUserService
    {
        private MARTContext _context;
        private readonly ApplicationManage _appSettings;
        private readonly IConfiguration _config;

        public UserService(
            MARTContext context,
            ApplicationManage configuration,
            IConfiguration config)
        {
            _context = context;
            _appSettings = configuration;
            _config = config;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress)
        {
            var Password = LIB.EncryptSvc(string.Empty, model.Password);
            var user = _context.Nguoidung.SingleOrDefault(x => x.Tendangnhap == model.Username && x.Matkhau == Password && x.Madonvi == this._appSettings.Madonvi);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt and refresh tokens
            var jwtToken = generateJwtToken(user, model.Remember);
            var refreshToken = generateRefreshToken(ipAddress);

            // save refresh token
            // user.RefreshTokens.Add(refreshToken);
            // _context.Update(user);
            // _context.SaveChanges();

            return new AuthenticateResponse(user, jwtToken, refreshToken.Token);
        }

        // public AuthenticateResponse RefreshToken(string token, string ipAddress)
        // {
        //     var user = _context.Nguoidung.SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token));

        //     // return null if no user found with token
        //     if (user == null) return null;

        //     var refreshToken = user.RefreshTokens.Single(x => x.Token == token);

        //     // return null if token is no longer active
        //     if (!refreshToken.IsActive) return null;

        //     // replace old refresh token with a new one and save
        //     var newRefreshToken = generateRefreshToken(ipAddress);
        //     refreshToken.Revoked = DateTime.UtcNow;
        //     refreshToken.RevokedByIp = ipAddress;
        //     refreshToken.ReplacedByToken = newRefreshToken.Token;
        //     user.RefreshTokens.Add(newRefreshToken);
        //     _context.Update(user);
        //     _context.SaveChanges();

        //     // generate new jwt
        //     var jwtToken = generateJwtToken(user);

        //     return new AuthenticateResponse(user, jwtToken, newRefreshToken.Token);
        // }

        public bool RevokeToken(string token, string ipAddress)
        {
            // var user = _context.Nguoidung.SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token));

            // // return false if no user found with token
            // if (user == null) return false;

            // var refreshToken = user.RefreshTokens.Single(x => x.Token == token);

            // // return false if token is not active
            // if (!refreshToken.IsActive) return false;

            // // revoke token and save
            // refreshToken.Revoked = DateTime.UtcNow;
            // refreshToken.RevokedByIp = ipAddress;
            // _context.Update(user);
            // _context.SaveChanges();

            return true;
        }

        public IEnumerable<Nguoidung> GetAll()
        {
            return _context.Nguoidung;
        }

        public Nguoidung GetById(string id)
        {
            return _context.Nguoidung.Find(id);
        }

        // helper methods
        private string generateJwtToken(Nguoidung user, bool RememberMe)
        {
            //claimns là nội dung ở phần payload, bạn có thể set các thông tin của người dùng tại đây
            var expires = DateTime.Now.AddDays(1);
            if (RememberMe)
            {
                expires = DateTime.Now.AddYears(1);
            }
            var claims = new List<Claim> {
                new Claim("Tendangnhap", user.Tendangnhap.ToString()),
                new Claim("Manhanvien",user.Manvcongno.ToString()),
                new Claim("Manhomquyen",user.Manhomquyen.ToString()),
                new Claim("Hovaten",user.Hovaten.ToString()),
                new Claim("Madonvi",user.Madonvi.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                expires: expires, //expire time là 30 phút
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private RefreshToken generateRefreshToken(string ipAddress)
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[64];
                rngCryptoServiceProvider.GetBytes(randomBytes);
                return new RefreshToken
                {
                    Token = Convert.ToBase64String(randomBytes),
                    Expires = DateTime.UtcNow.AddDays(7),
                    Created = DateTime.UtcNow,
                    CreatedByIp = ipAddress
                };
            }
        }
    }
}