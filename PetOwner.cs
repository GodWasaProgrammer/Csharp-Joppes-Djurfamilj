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

        public void Play()
        {
            Console.WriteLine("Play method");
            Console.WriteLine("Pick the animal with which you wish to interact");
            string petchoice = Console.ReadLine();
            selector = Int32.Parse(petchoice);
            // selector acts as index for petlist.

            pets[selector].Interact();
            
        }

        public void Feed()
        {
            Console.WriteLine("Feed");
        }

        public void Menu()

        {

            Console.WriteLine("Main Menu");
            Console.WriteLine("Menuchoice:");
            Console.WriteLine("1. Play Fetch");
            Console.WriteLine("2. Feed Animal");
            Console.WriteLine("3. List Joppes Animals");
            Console.WriteLine("Enter the appropriate number for your choice!");


            int menu = Int32.Parse(Console.ReadLine());

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


        }


        public override string ToString()
        {


            return "Petowner is Called:" + name + " and his age is:" + age;
        }

        public void AccessCurrentOwner()
        {

        }
    }

    


}
