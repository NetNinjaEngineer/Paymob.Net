namespace Paymob.Net.Models
{
    public sealed class AuthResponse
    {
        public Profile Profile { get; set; } = null!;

        public string Token { get; set; } = null!;
    }

}
