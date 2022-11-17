namespace Csharp_Joppes_Djurfamilj
{
    public class Dog : Animal
    {

        string type = "Dog";
        new string fav_food = "Steak";


        public void dog()

        {

        }

        public Dog(string name, int age)
            : base(name, age)
        {
            currenthunger = 2;


        }
        public new void Interact()
        {
            currenthunger--;

            if (currenthunger == 0)
            {
                Console.WriteLine($"The {type} is hungry and wont play.");
                Console.WriteLine($"The {type} Growls hungrily");
                Hungry_Animal();
            }
            else if (currenthunger > 0)
            {
                Console.WriteLine($"The {type} plays with joppe");
                this.currenthunger--;
                if (currenthunger == 0)
                {
                    hunger = true;
                }
            }
        }

        public override string ToString()
        {
            return "The" + type + "is called:" + base.name + "The" + type + " is" + base.age + "years old" + "his current hunger is:" + currenthunger;

        }
    }
}
