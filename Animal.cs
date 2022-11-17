namespace Csharp_Joppes_Djurfamilj
{
    public abstract class Animal
    {
        int Age;
        int CurrentHunger = 2;
        bool Hunger;

        public bool hunger {get { return Hunger; } set { Hunger = value; } }
        public int currenthunger { get { return CurrentHunger; } set { CurrentHunger = currenthunger; } }

        string Fav_food = "grass";

        public string fav_food { get { return Fav_food; } set { Fav_food = value; } }
        string Name;
        public string name { get { return Name; } set { Name = name; } }
        public int age { get { return Age; } set { Age = value; } }


        public override string ToString()
        {



            return "The Animal is called:" + Name + "And its :" + Age + "years old";
        }

        public void Interact()

        {

            if (currenthunger == 0)
            {
                Hungry_Animal();
            }
            else if(currenthunger > 0)
            { 
            {
                Console.WriteLine($"The Animal plays with joppe");
                    currenthunger--;

                if(currenthunger == 0)
                {
                    Hunger = true;
                }
                }
            }
        }

        public void Eat(string favoritefoodZ)
        {
            if(Hunger == true)
            { 
            if (favoritefoodZ == Fav_food)
            {
                if (currenthunger < 2)
                {
                    currenthunger++;
                }

                Console.WriteLine("Your Pet is fully fed.");
                Hunger = false;
            }

            else
            {
                    Console.WriteLine($"Your pet isnt hungry. values: {currenthunger} , {Hunger}");
            }
            }
        }

        public void Hungry_Animal()
        {
            Console.WriteLine("oOoooooOoooOooo hungry");
        }
        public Animal(string name, int Aage)
        {
            Name = name;
            Age = Aage;
            CurrentHunger = 2;
        }
    }


}
