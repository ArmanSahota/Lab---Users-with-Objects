using Lab___Users_with_Objects;
using System.Numerics;

class Program
{
    static List<Animal> animals = new List<Animal>();
    static void Main(string[] args)
    {
        Land cat = new Land("Fluffy", "Cat food", 3, 10, false, true, 10, 4, "House");
        animals.Add(cat);

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.ToString());
        }
    }
}

