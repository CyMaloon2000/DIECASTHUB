namespace DiecastHub.DTO.User.Request
{
    public class UserCreateDTO
    {
       public string Username { get; set; } = string.Empty;
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
