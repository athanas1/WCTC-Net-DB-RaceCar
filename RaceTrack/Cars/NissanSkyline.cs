using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class NissanSkyline : RaceCar
    { 
        public NissanSkyline()
        {
            Name = "Nissan Skyline";
            TopSpeed = 150;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} roars to life!");
        }
    }
}
