using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    /// <summary>
    /// This makes sure that admin behaviors are NOT in the users themselves!
    /// But rather a special interface that may be IMPLEMENTED alongside inheriting from `User`
    /// </summary>
    public interface IAdmin
    {
        void AccessAdmin();
    }
}
