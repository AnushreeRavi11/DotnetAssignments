using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create an console application to book train tickets. Create a Passanger class with (Name, Age) and 
    write a function called TicketBooking(int no_of_tickets) that takes no.of tickets to be booked. If the no of tickets is > 2 per booking, 
raise an user defined exception, and print "cannot book more than 2 tickets". Else Print  "Ticket Booked Successfully". 
Add a Test class to call TicketBooking method by accepting all required details.

*/


namespace Assisgnment_5
{
    class passanger
    {
        public string name;
        public int age;
        public int Ticketno;

        public void TicketBooking()
        {


            Console.WriteLine("ENter number of tickets ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 2)
                 {
                    throw (new NoOfPersonExceedsException(" Tickets should be less than 2"));
                }
                else
                {
                    Console.WriteLine(" ur ticket is booked");
                }

            }
            catch (NoOfPersonExceedsException fe)
            {
                Console.WriteLine(" Ticket booking failed { 0} ", fe.Message);
            }
        }
    }
    class NoOfPersonExceedsException : ApplicationException  //UserDefinedException
    {
        public NoOfPersonExceedsException(String msg) : base(msg)
        {



        }
    }
    class Program2
    {
        static void Main()
        {
            passanger p = new passanger();
            p.TicketBooking();
            Console.ReadLine();

        }
    }

}












