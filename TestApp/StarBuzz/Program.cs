using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage bev = new Espresso();
            Console.WriteLine(bev.getDescription() + " $" + bev.cost());

            Beverage bev2 = new DarkRoast();
            bev2 = new Mocha(bev2);
            bev2 = new Mocha(bev2);
            bev2 = new Whip(bev2);
            Console.WriteLine(bev2.getDescription() + " $" + bev2.cost());

            Beverage bev3 = new HouseBlend();
            bev3 = new Soy(bev3);
            bev3 = new Mocha(bev3);
            bev3 = new Whip(bev3);
            Console.WriteLine(bev3.getDescription() + " $" + bev3.cost());
        }
    }
}
