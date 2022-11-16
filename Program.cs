using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Csharp_Joppes_Djurfamilj
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Joppes Djurfamilj");

            PetOwner owner = new PetOwner();
            owner.Name = "Joppe";
            owner.Age = 25;

            int age = 5;
            string petname = "fido";

            owner.pets.Add(new Dog(petname,age));
            
            owner.pets.Add(new Cat(petname,age));
            Console.WriteLine(owner.ToString());

            owner.List_Animals();



            owner.Menu();

            
            
        }
    }
}