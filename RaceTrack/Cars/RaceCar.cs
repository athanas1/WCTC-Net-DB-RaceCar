using System;
using RaceTrack.RaceTrack.Drivers;
using System.Threading;
using System.Collections.Generic;
using RaceTrack.RaceTrack;


namespace RaceTrack.RaceTrack.Cars
{
    public abstract class RaceCar
    {
        protected RaceCar()
        {
            Position = 0;
        }

        public string Name { get; set; }
        public int Position { get; set; }
        public int TopSpeed { get; set; }

        public void Accelerate(int driverSkill)
        {
            // applying a random amount of variability to affect the outcome
            var random = new Random();
            var randomRange = random.Next(-1, 20);
            Position += driverSkill * TopSpeed * randomRange;

            if (Position > 0)
                Console.WriteLine($"{Name} moves ahead to {Position}!");
            else if (Position < 0)
                Console.WriteLine($"{Name} moves backwards to {Position}!??");
            else
                Console.WriteLine($"{Name} has stopped!?");
        }

        public abstract void StartEngine();

       public abstract void StopEngine();


        public virtual void Brake()
        {
            Console.WriteLine($"The {Name} ends in position {Position}!");
        }
    }
}