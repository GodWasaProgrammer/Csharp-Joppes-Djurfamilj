using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Joppes_Djurfamilj
{
    public class Puppy:Dog
    {
        int months;
        string type = "Puppy";

        public Puppy(string name, int age, int months) : base(name, age)
        {
            this.months = months;   
        }



        public override string ToString()
        {
            return "The " + type + " is called: " + base.name + ", The " + type + " is " + months + " months old";

        }

    }
}
