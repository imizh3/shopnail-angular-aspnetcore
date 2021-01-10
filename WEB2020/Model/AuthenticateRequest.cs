using System.ComponentModel.DataAnnotations;

namespace WEB2020.Model
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public bool Remember { get; set; }
    }
}