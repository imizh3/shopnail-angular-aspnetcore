using System.Text.Json.Serialization;
using WEB2020.Models;

namespace WEB2020.Model
{
    public class AuthenticateResponse
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string JwtToken { get; set; }

        [JsonIgnore] // refresh token is returned in http only cookie
        public string RefreshToken { get; set; }

        public AuthenticateResponse(Nguoidung user, string jwtToken, string refreshToken)
        {
            Id = user.Tendangnhap;
            FirstName = user.Hovaten;
            LastName = user.Hovaten;
            Username = user.Tendangnhap;
            JwtToken = jwtToken;
            RefreshToken = refreshToken;
        }
    }
}