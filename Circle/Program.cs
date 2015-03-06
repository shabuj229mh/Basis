using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double perimeter;
            double radius;
            Console.WriteLine("Give me the radius:");
            //Console.ReadLine();
            radius = Convert.ToDouble(Console.ReadLine());
            perimeter = 2*radius;
            Console.WriteLine("The primeter is:"+ perimeter);

            Console.ReadKey();
        }

    }
}
