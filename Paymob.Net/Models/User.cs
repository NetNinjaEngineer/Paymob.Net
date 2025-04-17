namespace Paymob.Net.Models
{
    public sealed class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateJoined { get; set; }
        public string Email { get; set; } = null!;
        public bool IsActive { get; set; }

        public bool IsStaff { get; set; }

        public bool IsSuperuser { get; set; }

        public object LastLogin { get; set; } = null!;

        public List<object> Groups { get; set; } = [];
        public List<int> UserPermissions { get; set; } = [];
    }
}
