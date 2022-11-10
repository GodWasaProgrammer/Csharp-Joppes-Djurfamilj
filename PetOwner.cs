using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Joppes_Djurfamilj
{
    public class PetOwner
    {
        int age;
        List<Animal> pets = new List<Animal>();
        public int Age { get { return age; } set { age = value; } }


        public void List_Animals()
        {

        }

        public void Play()
        {

        }


        public void Feed()
        {

        }

        public void Menu()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }


    
}
