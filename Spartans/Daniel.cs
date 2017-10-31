using System;

namespace DemoBranch.Spartans
{
    public sealed class Daniel
    {
        private static Daniel instance = null;
        private static readonly object padLock = new object();

        public static Daniel Instance
        {
            get
            {
                lock (padLock)
                {
                    if (instance == null)
                    {
                        instance = new Daniel();
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
