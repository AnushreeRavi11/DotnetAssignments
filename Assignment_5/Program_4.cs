using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create an Interface IStudent with int StudentId and string Name as Properties, void ShowDetails() as its method.*/
/*
Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods. ShowDetails() should show DaysScholar details and Resident Details accordingly.*/

namespace Assignment_5
{
    interface Istudent
    {
        string name { get; set; }
        int id { get; set; }

        void showdetails();



    }
    class Dayscholors : Istudent
    {
        string Name;
        int Id;
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }

        }

        public int id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public void showdetails()
        {
            Console.WriteLine(" Dayscholar Deatils");
            Console.WriteLine(" Student name " + Name);
            Console.WriteLine("StudentId" + Id);
        }



    }
    class Resident : Istudent
    {
        string Name;
        int Id;
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }

        }

        public int id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public void showdetails()
        {
            Console.WriteLine(" Resident  Deatils");
            Console.WriteLine(" Student name " + Name);
            Console.WriteLine("StudentId" + Id);
        }
    }
    class Program_4
    {
        public static void Main(string[] args)
        {
            Istudent st = new Dayscholors();
            Console.WriteLine("Enter dayscholor Name ");
            st.name = Console.ReadLine();
            Console.WriteLine("Enter dayschole id");
            st.id = Convert.ToInt32(Console.ReadLine());
            st.showdetails();
            Istudent si = new Resident();
            Console.WriteLine("Enter Residence Name ");
            si.name = Console.ReadLine();
            Console.WriteLine("Enter dayschole id");
            si.id = Convert.ToInt32(Console.ReadLine());
            si.showdetails();
            Console.ReadLine();


        }
    }
}





