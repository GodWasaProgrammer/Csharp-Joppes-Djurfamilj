namespace Csharp_Joppes_Djurfamilj
{
    public class PetOwner
    {
        int age;
        public List<Animal> pets = new List<Animal>();

        public int Age { get { return age; } set { age = value; } }

        private string name;

        public string Name { get { return name; } set { name = value; } }
        public int Count { get { return pets.Count; } }

        public int selector;


        public void List_Animals()
        {
            foreach (object animals in pets)
            {
                Console.WriteLine(animals);
            }

        }

        public void PetChoice()
        {
            Console.WriteLine("Pick the animal with which you wish to interact");
            string petchoice = Console.ReadLine();
            selector = Int32.Parse(petchoice);
            // selector is index 
        }
        public void Play()
        {
            Console.WriteLine("Play method");
            
            List_Animals();
            PetChoice();
            // selector acts as index for petlist.

            pets[selector].Interact();

        }

        public void Feed()
        {
            string FoodIN;
            int Foodchoice;

            Console.WriteLine("Pick the food you wish to feed the animal with,input correlating number");
            Console.WriteLine("1. steak");
            Console.WriteLine("2. Catnip");
            
            Foodchoice = Int32.Parse(Console.ReadLine());

            if(Foodchoice == 1)
            {
                FoodIN = "steak";
                PetChoice();
                pets[selector].Eat(FoodIN);
                pets[selector].currenthunger++;
                pets[selector].currenthunger++;
            }

            if (Foodchoice == 2)
            {
                FoodIN = "Catnip";
                PetChoice();
                pets[selector].Eat(FoodIN);
                pets[selector].currenthunger++;
                pets[selector].currenthunger++;
            }

            

        }

        public void Menu()

        {
            int menu;
            int loop;
            do
            {

                Console.WriteLine("Main Menu");
            Console.WriteLine("Menuchoice:");
            Console.WriteLine("1. Play Fetch");
            Console.WriteLine("2. Feed Animal");
            Console.WriteLine("3. List Joppes Animals");
            Console.WriteLine("Enter the appropriate number for your choice!");
            

            
                menu = Int32.Parse(Console.ReadLine());
                loop = menu;

                switch (menu)
                {
                    case 1:

                        Play();
                        break;

                    case 2:
                        Feed();
                        break;
                    case 3:
                        List_Animals();
                        break;
                    default:
                        Console.WriteLine("Incorrect choice");
                        throw new ArgumentOutOfRangeException("Unknown Value");



                }
            } while (loop != 4);

        }


        public override string ToString()
        {


            return "Petowner is Called:" + name + " and his age is:" + age;
        }


    }




}
