using System.Text.Json.Serialization;

namespace Paymob.Net.Models
{
    public sealed class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; } = null!;

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; } = null!;

        [JsonPropertyName("last_name")]
        public string LastName { get; set; } = null!;

        [JsonPropertyName("date_joined")]
        public DateTime DateJoined { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; } = null!;

        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("is_staff")]
        public bool IsStaff { get; set; }

        [JsonPropertyName("is_superuser")]
        public bool IsSuperuser { get; set; }

        [JsonPropertyName("last_login")]
        public object LastLogin { get; set; } = null!;

        [JsonPropertyName("groups")]
        public List<object> Groups { get; set; } = [];

        [JsonPropertyName("user_permissions")]
        public List<int> UserPermissions { get; set; } = [];
    }



}
