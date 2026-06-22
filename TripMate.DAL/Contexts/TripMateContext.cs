using Microsoft.AspNet.Identity.EntityFramework;
using TripMate.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripMate.DAL.Contexts
{
    public partial class TripMateContext : IdentityDbContext<User>
    {
    }
}
