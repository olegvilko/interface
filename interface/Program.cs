using System;

namespace @interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            Console.WriteLine(ship.Test("Oleg"));
            Console.ReadKey();
        }
    }

    public class Ship : IShip
    {
        public string Test(string str)
        {
            return str;
        }
    }

    public interface IShip
    {
        string Test(string str);
    }
}
