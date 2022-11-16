using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Joppes_Djurfamilj
{
    public class Cat : Animal
    {

        public Cat(string name, int age)
            :base(name, age)
        {

        }

        

        public override string ToString()
        {
            return "The Animal is a Cat and its named:" + base.name + ", and its " + base.age + "years old";
        }
        public void Interact()
        {
            Console.WriteLine($"The cat plays with{0}");
        }

    }
    
}
