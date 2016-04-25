using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace SecondZoo
{
    public class Car : INoise
    {
        public void MakeNoise()
        {
            SoundPlayer sp = new SoundPlayer(@"..\..\Sound\RaceCar.wav");

            Console.Write("En bil...");
            sp.PlaySync();
            Console.WriteLine("...kör förbi.");
        }
    }
}
