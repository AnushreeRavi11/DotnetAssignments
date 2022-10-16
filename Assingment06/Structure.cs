using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment06
{

    struct Book
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;



        public void getvalues(string t, string a, string st, int b)
        {
            title = t;
            author = a;
            subject = st;
            book_id = b;


        }
        public void showvalues()
        {
            Console.WriteLine(" Title: {0}", title);
            Console.WriteLine(" author : {0}", author);
            Console.WriteLine("subject :{0}", subject);
            Console.WriteLine("book_id: {0}", book_id);

        }
    }

    class Structure
    {

        public static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.getvalues("phy", "anu", " physics", 23);
            b1.getvalues("che", "thanu", "chemistry", 34);
            b1.showvalues();
            Console.WriteLine(" ==============");
            Console.ReadLine();


        }
    }
}
