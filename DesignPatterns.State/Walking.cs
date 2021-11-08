using System;

namespace DesignPatterns.State
{
    public class Walking : ITravelMode
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating direction (walking)");
            return 3;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (walking)");
            return 3;
        }
    }
}
