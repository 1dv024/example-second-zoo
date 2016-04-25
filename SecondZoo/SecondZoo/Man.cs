using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace SecondZoo
{
    public class Man : INoise
    {
        public void MakeNoise()
        {
            SoundPlayer sp = new SoundPlayer(@"..\..\Sound\LongLaugh.wav");

            Console.Write("En man skrattar...");
            sp.PlaySync();
            Console.WriteLine("...för mycket");
        }
    }
}
