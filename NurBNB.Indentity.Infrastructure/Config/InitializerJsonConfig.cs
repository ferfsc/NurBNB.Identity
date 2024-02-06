using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurBnb.Identity.Infrastructure.Config;

internal class InitializerJsonConfig
{
    public List<InitializerJsonRole> roles { get; set; }
    public List<InitializerJsonUser> users { get; set; }
}
