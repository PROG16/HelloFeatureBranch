using System;

namespace DemoBranch.Spartans
{
    public sealed class DannyBoy
    {
        private static DannyBoy instance = null;
        private static readonly object padLock = new object();

        public static DannyBoy Instance
        {
            get
            {
                lock (padLock)
                {
                    if (instance == null)
                    {
                        instance = new DannyBoy();
                    }
                    return instance;
                }
            }
        }

        public void MakeTheSound()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Woop woop, thats the sound of the police ♪♫♬");
            }
        }
    }
}
