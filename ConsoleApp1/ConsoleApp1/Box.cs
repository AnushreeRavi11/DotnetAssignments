using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Box
    {
        int length;
        int breadth;

        public int Adds(int a, int b)
        {
            int result;
            result = length + breadth;
            return result;


        }
        public static void Main(String[] args)
        {
            Box b2 = new Box();
            
            Console.WriteLine("Enter length");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            int b = Convert.ToInt32(Console.ReadLine());
            b.Adds(6,7);
            Console.ReadLine();

        }
    }
}
