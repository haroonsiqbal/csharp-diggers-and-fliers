using System.Collections.Generic;

namespace diggers_and_fliers {
    public class DiggingContainer
    {
        public List<IDigging> DiggingAnimals {get; set;} = new List<IDigging>();
    }
    public class FlyingContainer
    {
        public List<IFlying> FlyingAnimals {get; set;} = new List<IFlying>();
    }
    public class WalkingContainer
    {
        public List<IWalking> WalkingAnimals {get; set;} = new List<IWalking>();
    }
    public class SwimmingContainer
    {
        public List<ISwimming> SwimmingAnimals {get; set;} = new List<ISwimming>();
    }
}