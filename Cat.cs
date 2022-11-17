using System.Security.Cryptography.X509Certificates;

namespace Csharp_Joppes_Djurfamilj
{
    public class Cat : Animal
    {
        string type = "Cat";
        new string fav_food = "Catnip";

        public Cat(string name, int age)
            : base(name, age)
        {
            currenthunger = 2;
        }

        public new void Interact()
        {
            if (currenthunger == 0)
            {
                Hungry_Animal();
            }
            else
            {
                Console.WriteLine($"The {type} plays with joppe");
                currenthunger--;
                if (currenthunger == 0)
                {
                    hunger = true;
                }
            }
        }

        public override string ToString()
        {
            return "The " + type + "is called:" + base.name + ", and its " + base.age + "years old";
        }

        
        public new void Hungry_Animal()
        {

            Console.WriteLine("Cat meows angrily while looking at you");
            Console.WriteLine("Your kitty goes chasing mice instead.");
            Console.WriteLine("Your Cat has a 50% chance of catching a mouse.");

            Random ProbabilityofcatchingaMouse = new Random();
            int probabibility;

            probabibility = ProbabilityofcatchingaMouse.Next(0, 1);


            if (probabibility == 1)
            {

                Console.WriteLine("meow meow your cat catches a mouse");
                Console.WriteLine("Your cat is fully fed");
                if (currenthunger < 2)

                {
                    currenthunger++;
                }

                else if (probabibility == 0)
                {
                    Console.WriteLine("Your cat fails to catch anything");
                    Console.WriteLine("Therefor he is still hungry");
                }


            }

            

        }

    }

}
