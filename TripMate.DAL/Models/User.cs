using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNetCore.Identity;


namespace TripMate.DAL.Models
{
    public class User : IdentityUser
    {
        string name;
        string username;
        string password;
        string email;
        string occupation;
        string phone;
        string city;
        string country;
        Shared.UserRole role;
        string nid;
        string dob;
    }
}
