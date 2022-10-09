using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///*

//12. Create an Abstract class Student with  Name, StudentId, Grade as members and also an abstract method Boolean Ispassed(grade)
//which takes grade as an input and checks whether student passed the course or not.  

//Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method 

//For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. For the Grad class,
//if the grade is above 80.0, then isPassed returns true, otherwise returns false./*

namespace Assisgnment_5
{

    public abstract class Student
    {
        public string name;
        public int StudentId;
        public float grade;


        public abstract Boolean Ispassed(float grade);

        

    }
    public class Undergraduate : Student
    {
        
        public override bool Ispassed(float grade)
        {
            if (grade >= 70.0f)
            {
                Console.WriteLine("UnderGraduate Passed ");
                return true;
            }
            else
            {
                Console.WriteLine("Undergraduate failed");
                return false;
            }
        }


    }

    public class graduate : Student
    {

        public override bool Ispassed(float grade)
        {
            if (grade >= 80.0f)
            {
                Console.WriteLine(" Graduate Passed ");
                return true;
            }
            else
            {
                Console.WriteLine(" Graduate Failed ");
                return false;
            }
        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            

            Student s = new Undergraduate();

            s.name = " Appa";
            s.StudentId = 90;
            s.Ispassed(70.0f);
            graduate g = new graduate();
            g.name = " Harish";
            g.StudentId = 40;
            g.Ispassed(70.0f);
            Console.ReadLine();


        }
    }
}
