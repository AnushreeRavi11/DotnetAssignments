using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment06
{
    class Product
    {
        int ProductId;
        string ProdName;
        double  price;
     

       
        
        public static void Main(string[] args)
        {
            List<Product> product = new List<Product> {

                new Product{ProductId= 001,ProdName=" soap", price=4500d},
                new Product{ProductId= 002,ProdName=" paste ", price=8700d},
                new Product{ProductId= 003,ProdName="  brush", price=459087d},
                new Product{ProductId= 004,ProdName=" craem", price=476400},
                new Product{ProductId= 005,ProdName="boo", price=4900d},
                new Product{ProductId= 006,ProdName=" pen", price=4500d },
                new Product{ProductId= 007,ProdName=" box", price=4500d},
                new Product{ProductId= 008,ProdName=" bottle", price=4500d},
                new Product{ProductId= 009,ProdName=" bag", price=4500d}
                };

            var shop = product.OrderBy(Prod=>Prod.ProdName).ToList();
                foreach ( var v in shop  )
            {
                Console.WriteLine("name: {0}     id: {1}     price: {2} ", v.ProdName, v.ProductId ,v.price);
                
                             
            }
            Console.ReadLine();
        }
    }

}
