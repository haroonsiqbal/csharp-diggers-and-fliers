using System;

namespace diggers_and_fliers {
    public class Parakeet : IFlying
    {
        public int MaximumAltitude {get;} = 20;

        public void Fly()
        {
            Console.WriteLine("Animal is now flying");
        }
    }
    public class Earthworm : IDigging
    {
        public int MaxDigDepth {get;} = 30;

        public void Dig()
        {
            Console.WriteLine("Animal is now digging");
        }
        }

    public class Terrapin : ISwimming
    {
        public int MaximumDepth {get;} = 40;

        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }

    }

    public class TimberRattlesnake : IWalking
    {
        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now running");
        }
    }

    public class Mouse : IWalking
    {
        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
    }

    public class Ant : IDigging
    {
        public int MaxDigDepth {get;} = 10;

        public void Dig()
        {
            Console.WriteLine("Animal is now digging");
        }
    }
    public class Finch : IFlying
    {
        public int MaximumAltitude {get;} = 70;

        public void Fly()
        {
            Console.WriteLine("Animal is now flying");
        }
    }
    public class BettaFish : ISwimming
    {
        public int MaximumDepth {get;} = 60;

        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }
    }
    public class CopperheadSnake : IWalking
    {
        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
    }
    public class Gerbil : IWalking
    {
        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
    }
}