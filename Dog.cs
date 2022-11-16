using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Joppes_Djurfamilj
{
    public class Dog : Animal
    {
        public void dog()

        {
            
        }

        public Dog(string name, int age)
            :base(name, age)
        {
            
            

        }

        public override string ToString()
        {
            return "The Dog is called:" + base.name + "The dog is" + base.age + "years old";

        }
    }
}
