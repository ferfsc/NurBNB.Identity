using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurBnb.Identity.Infrastructure.PersistenceModel
{
    public class ApplicationPermission
    {
        public string Mnemonic { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public static Dictionary<string, ApplicationPermission> Permissions { get;  } = new Dictionary<string, ApplicationPermission>();

        public ApplicationPermission()
        {
        }

        internal ApplicationPermission(string mnemonic, string name, string description)
        {
            Mnemonic = mnemonic;
            Name = name;
            Description = description;
        }

        public static List<ApplicationPermission> GetAllPermissions()
        {
            return Permissions.Values.ToList<ApplicationPermission>();
        }

        public static ApplicationPermission GetPermission(string mnemonic)
        {
            return Permissions[mnemonic];
        }
    }
}
