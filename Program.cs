using System;

namespace diggers_and_fliers
{
    class Program
    {
        static void Main(string[] args)
        {
            //create animal instances
            Earthworm jim = new Earthworm();
            Ant paul = new Ant();
            Parakeet sam = new Parakeet();
            Finch david = new Finch();
            Mouse mickey = new Mouse();
            Gerbil dave = new Gerbil();
            Terrapin lucy = new Terrapin();
            BettaFish becky = new BettaFish();

            //create containers
            DiggingContainer digcontainer = new DiggingContainer();
            FlyingContainer flycontainer = new FlyingContainer();
            WalkingContainer walkcontainer = new WalkingContainer();
            SwimmingContainer swimcontainer = new SwimmingContainer();
            
            //add animals to corresponding container
            digcontainer.DiggingAnimals.Add(jim);
            digcontainer.DiggingAnimals.Add(paul);
            flycontainer.FlyingAnimals.Add(sam);
            flycontainer.FlyingAnimals.Add(david);
            walkcontainer.WalkingAnimals.Add(mickey);
            walkcontainer.WalkingAnimals.Add(dave);
            swimcontainer.SwimmingAnimals.Add(lucy);
            swimcontainer.SwimmingAnimals.Add(becky);

            foreach (var item in digcontainer.DiggingAnimals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
