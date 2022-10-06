using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Ass
{
    class Program
    { 
        public void three()
        {
            int[] arr = new int[5] { 3, 5, 8, 9,4 };
            Console.WriteLine("The length od Arrya is{0}----->", arr.Length);
            Console.WriteLine("reverse the given array{0}",    arr.Reverse());
            

            



          }

        public void  call()
        {
            int[] num = new int[4] { 5,9,8,10 };

            Console.WriteLine("**************************************");
            Console.WriteLine("Total Value of a Integer is {0}", num.Sum());
            Console.WriteLine("maxmum value of a integer is {0}", num.Max());
            Console.WriteLine("Avarage value of a intger is {0}", num.Average());
            Console.WriteLine(  "Minimum value of Integer is {0}",num.Min());
            Console.WriteLine("Descending value of Integer is {0}");
            Array.Reverse(num);

              

        
        }
        public void calls()
        {
            int[] arr = new int[] { 10, 20, 30, 40 };

            Console.WriteLine("minimum value of a integer is {0}", arr.Max());
            Console.WriteLine("maxmum value of a integer is {0}", arr.Min());
            Console.WriteLine("Avarage value of a intger is {0}", arr.Average());
            Console.ReadLine();


        }
        static void Main(string[] args)

        {
            
            Program p = new Program();
            p.call();
            p.calls();
            p.three();
            
            Console.ReadLine();
           


        }





    }
}
