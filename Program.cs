namespace Csharp_Joppes_Djurfamilj
{
    public class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Joppes Djurfamilj");
            Console.WriteLine("-----------------------------------------------");
            PetOwner owner = new PetOwner();
            owner.Name = "Joppe";
            owner.Age = 25;
            int age = 5;
            string petname = "fido";
            owner.pets.Add(new Dog(petname, age, "Labrador"));
            owner.pets.Add(new Cat("Meowzer", 3, "Maine Coon"));
            owner.pets.Add(new Puppy("Mini", 0 , 8, "Great Dane"));
            Console.WriteLine(owner.ToString());
            owner.List_Animals();
            owner.Menu();
        }
    }
}