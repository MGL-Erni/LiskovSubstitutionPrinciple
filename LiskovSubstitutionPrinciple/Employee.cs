﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    /// <summary>
    /// Employee does not implement Admin interface, i.e. no admin access 
    /// </summary>
    public class Employee : User
    {
        public Employee(string name) : base(name)
        {
        }
    }
}
