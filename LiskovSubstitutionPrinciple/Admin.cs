using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    /// <summary>
    // Admin class implementing IAdmin
    /// </summary>
    public class Admin : User, IAdmin
    {
        // inherit ctor from User, i.e. _name
        public Admin(string name) : base(name)
        {
        }

        public void AccessAdmin()
        {
            // AccessAdmin logic
            Console.WriteLine($"{_name} has accessed admin.");
        }
    }
}
