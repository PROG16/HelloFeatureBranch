using DemoBranch.DancingStickMan;
using DemoBranch.Spartans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBranch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Hello World-appen!");
            AndreChabbePatrik.Write();
            Fredrik.Speak();

            var dannysSingleton = Daniel.Instance;
            dannysSingleton.MakeTheSound();

            Console.ReadLine();
            Perly.Speak();
            EsterBergstrom.Speak();
            JesperAndreas.Speak();
            DanceMan.DanceAway(2);
            Console.ReadLine();
        }
    }
}
