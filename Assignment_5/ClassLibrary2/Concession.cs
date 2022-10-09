using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Concession
    {
        int TotalFare = 500;
        float Concessionamount;
        float calculatedamoount;

        public void CalculateConcession(int age)
        {

            if (age <= 5)
            {
                Console.WriteLine(" Litlr champs free ticket ");
            }
            else if (age >= 60)
            {
                Concessionamount = (0.3f * TotalFare);
                calculatedamoount = TotalFare - Concessionamount;
                Console.WriteLine(" seniorcitizen" + calculatedamoount);
            }
            else
            {
                Console.WriteLine("Totalfare " + TotalFare);
            }

        }
    }

}
