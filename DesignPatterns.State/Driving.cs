using System;

namespace DesignPatterns.State
{
    public class Driving : ITravelMode
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating direction (driving)");
            return 1;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }
    }
}
