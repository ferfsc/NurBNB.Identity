using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurBnb.Identity.Infrastructure.Config
{
    internal class InitializerJsonUser
    {
        public string user { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string jobtitle { get; set; }
        public List<InitializerJsonUserRole> userroles { get; set; }
    }
}
