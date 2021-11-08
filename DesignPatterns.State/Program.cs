using System;

namespace DesignPatterns.State
{
    class Program
    {
        static void Main()
        {
            var service = new DirectionService(new Walking());
            service.GetEta();
            service.GetDirection();

            service.SetTravelMode(new Driving());
            service.GetEta();
            service.GetDirection();

            Console.ReadLine();
        }
    }
}
