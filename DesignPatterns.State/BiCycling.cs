using System;

namespace DesignPatterns.State
{
    public class BiCycling : ITravelMode
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating direction (bicycling)");
            return 2;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 2;
        }
    }
}
