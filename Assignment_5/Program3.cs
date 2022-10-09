using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
/*I.  Create a class library Project called Concession. Write a method called CalculateConcession(int age)  that takes age as an input and calculates concession for travel as below:
If age<=5 then “Little Champs- Free Ticket” should be displayed
If age >60 then calculate 30% concession on the totalfare(Which is a constant Eg:500/-) and Display “ Senior Citizen” + Calculated Fare
Else “Print Ticket Booked” + Fare. 

II. Create a Console application with a Class called Program which has int TotalFare as Constant, Name, Age.  Accept Name, Age from the user and call the CalculateConcession() function
(Hint : Add required references)*/

namespace Assignment_5
{
    class Program3
    {



        public static void Main(string[] args)
        {


Console.WriteLine("Enter your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Age"); 
            int age = Convert.ToInt32(Console.ReadLine());
            Concession concession = new Concession();      
           concession.CalculateConcession(age);            
            Console.ReadLine();


        }
    }
}
