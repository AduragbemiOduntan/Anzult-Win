using Anzult_Win_UI.Common.Enum;

namespace Anzult_Win_UI.Domain.Model
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRole UserRole { get; set; }
    }
}
