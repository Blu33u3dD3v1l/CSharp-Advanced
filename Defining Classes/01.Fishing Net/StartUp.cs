using System;

namespace FishingNet
{
    public class StartUp
    {
        static void Main()
        {
            // Initialize the repository (Net)
            Net net = new Net("cast net", 10);

            // Initialize entity
            Fish fishOne = new Fish("salmon", 44.25, 941.15);
            Fish fishTwo = new Fish("catfish", 105.25, 2100.15);
            Fish fishThree = new Fish("bass", 25.25, 321.15);

            // Add Fish
            Console.WriteLine(net.AddFish(fishOne));  // Successfully added salmon to the fishing net.
            Console.WriteLine(net.AddFish(fishTwo));  // Successfully added carfish to the fishing net.
            Console.WriteLine(net.AddFish(fishThree));// Successfully added bass to the fishing net.
            Console.WriteLine(net.Count); // 3

          




        }

    }
}
