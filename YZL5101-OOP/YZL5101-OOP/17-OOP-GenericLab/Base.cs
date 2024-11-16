using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_GenericLab
{
    internal abstract class Base
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public Status Status { get; set; }
        public abstract void CalculateSalary();
    }
}
