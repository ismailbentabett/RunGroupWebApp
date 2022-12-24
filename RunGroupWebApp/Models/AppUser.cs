using Microsoft.AspNetCore.Identity;

namespace RunGroupWebApp.Models
{
    public class AppUser : IdentityUser
    {
        public  Adress? Adress { get; set; }
        public int? Pace { get; set; }

        public int? Mileage { get; set; }


    }
}
