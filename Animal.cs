using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Joppes_Djurfamilj
{
    public abstract class Animal
    {
        int Age;
        int CurrentHunger;
        public int currenthunger { get { return CurrentHunger; } set { CurrentHunger = currenthunger; } }

        string Name;
        public string name { get { return Name; } set { Name = name; } }
        public int age { get { return Age; } set { Age = value; } }


        public override string ToString()
        {



            return "The Animal is called:" + Name + "And its :" + Age + "years old";
        }

        public void Interact()
        {
            
        }

        public Animal(string name, int Aage)
        {
            Name = name;
            Age = Aage;
        }
    }


}
