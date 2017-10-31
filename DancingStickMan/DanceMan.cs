using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBranch.DancingStickMan
{
    public static class DanceMan
    {
        public static void DanceAway(int dances)
        {
            for (int i = 0; i < dances; i++)
            {
                Console.WriteLine("\nDansa!\n");
                Console.WriteLine(@"/o/   \o\   /o/   \o\");
                Console.WriteLine(@" |     |     |     |");
                Console.WriteLine(@" /\    /\    /\    /\");
                Console.WriteLine("\nPausa!\n");
            }
        }
    }
}
