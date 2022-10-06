using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        int a, c, b,num1,num2,k,T,m;
        

        public static void Main(string[] args)
        {
            Program p = new Program();
             p.add();
             
            p.Postive();
            
            p.Compare();
            Console.ReadLine();
        }
        public void Postive()
        {

            Console.WriteLine("enter num1 value ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2 value");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 0)

                Console.WriteLine(" Yes the given number is postive ");

            else
                Console.WriteLine("the number is negative");

        }
        public void Compare()
        {
            Console.WriteLine("Enter k value ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter m value ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter your choice ");
            Console.WriteLine("1 Addition of 2 number");
            Console.WriteLine("2 Subsrtraction");
            Console.WriteLine("3 Division");
            Console.WriteLine("4 multiplication");
            
             c=Convert.ToInt32(Console.ReadLine());

            
            switch (c)
            {
                case 1:
                    T = k + m;
                    Console.WriteLine("Addition of 2 number "+T);
                    break;
                case 2:
                    T = k - m;
                    Console.WriteLine("Substraction of 2 number "+T);
                    break;
                case 3:
                    T = k * m;
                        Console.WriteLine(  "Multiplication of 2 number "+T);
                    break;
                case 4:
                    T = k / m;
                    Console.WriteLine("Division of 2 numbers"+T);
                    break;
                default:
                    Console.WriteLine(" entered wrong number  " + T);
                    break;
                    

            }



           
           
        }


            public void add()
        {

            Console.WriteLine("enter a value ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b value");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)

                Console.WriteLine("yes ");

            else

                Console.WriteLine("No");

        }

        }

    }







