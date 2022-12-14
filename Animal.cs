namespace Csharp_Joppes_Djurfamilj
{
    public abstract class Animal
    {
        int Age; // the animals age
        bool Hunger; // animals hunger bool
        public bool hunger { get { return Hunger; } set { Hunger = value; } } // property for Hunger
        string Fav_food; // favorite food. overridden in derivative classes
        public string fav_food { get { return Fav_food; } set { Fav_food = value; } } // fav food property
        string Name;
        public string name { get { return Name; } set { Name = name; } } // name property
        public int age { get { return Age; } set { Age = value; } } // Age property
        string breed;
        public string Breed { get { return breed; } set { breed = Breed; } }
        public override string ToString()
        {
            return "The Animal is called:" + Name + "And its :" + Age + "years old, and is a " + breed;
        }
        public virtual void Interact()
        {
            if (hunger == true)
            {
                Hungry_Animal();
            }
            else if (hunger == false)
            {
                {
                    Console.WriteLine($"The Animal plays with joppe");
                    hunger = true;
                }
            }
        }
        public virtual void Eat(string favoritefoodZ)
        {
            if (favoritefoodZ == Fav_food)
            {
                hunger = false;
                Console.WriteLine($"Your pet eats the{Fav_food}");
            }
            if (Fav_food != favoritefoodZ)
            {
                Console.WriteLine("Your pet doesnt like the type of food.");
            }
        }
        public virtual void Hungry_Animal()
        {
            Console.WriteLine("oOoooooOoooOooo hungry");
        }
        public Animal(string name, int Aage, string inputbreed)
        {
            Name = name;
            Age = Aage;
            breed = inputbreed;
        }
    }
}
