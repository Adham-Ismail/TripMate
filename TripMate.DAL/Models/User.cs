using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNet.Identity.EntityFrameworkCore;
//using Microsoft.AspNetCore.Identity;


namespace TripMate.DAL.Models
{
    public class User : IdentityUser
    {
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string occupation { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public Shared.Enums.UserRoles role { get; set; } = Shared.Enums.UserRoles.Customer;
        private string nid { get; set; }
        public string dob { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
