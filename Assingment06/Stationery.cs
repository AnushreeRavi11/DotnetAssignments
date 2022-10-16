using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment06
{
    class Stationery
    {
        public static void Main()
        {
            List<int> intlist = new List<int>();
            intlist.Add(39);
            intlist.Add(13);
            intlist.Add(3);
            intlist.Add(30);
            intlist.Sort();
            foreach (int n in intlist)
            {
                Console.WriteLine(n);
            }
            List<string> strlist = new List<string>();
            strlist.Add("Varsha");
            strlist.Add("Divyashree");
            strlist.Add("SaiRoopa");
            strlist.Add("Anupa");

            strlist.Sort();
            foreach (string n in strlist)
            {
                Console.WriteLine(n);
                
            }
            Console.ReadLine();

           
        }
    }
}
