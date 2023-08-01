using Microsoft.AspNetCore.Identity;

namespace CAsgem_IdentityRole.DAL
{
    public class AppUser:IdentityUser<int>
    {
        public string NameSurname { get; set; }
    }
}
