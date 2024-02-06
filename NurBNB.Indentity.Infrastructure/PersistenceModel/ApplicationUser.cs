using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurBnb.Identity.Infrastructure.PersistenceModel
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool Active { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public bool Staff { get; set; }

        public ApplicationUser(string username, string firstName, string lastName, bool active, bool staff) : base(username)
        {
            LastName = lastName;
            FirstName = firstName;
            Active = active;
            Staff = staff;
        }

        private ApplicationUser()
        {
            LastName = "";
            FirstName = "";
        }
    }
}
