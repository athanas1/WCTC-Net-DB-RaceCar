using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Ricardo : Driver
    {
        public Ricardo(RaceCar car) : base(car)
        {
            Name = "Ricardo";
            SkillLevel = 13;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}
