using Microsoft.AspNet.Identity.EntityFramework;
using System;
//using Microsoft.AspNet.Identity.EntityFrameworkCore;
//using Microsoft.AspNetCore.Identity;


namespace TripMate.DAL.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; } = true;
        public bool Tracking { get; set; } = false;
        public Shared.Enums.UserStatus Status { get; set; } = Shared.Enums.UserStatus.Active;

    }
}
