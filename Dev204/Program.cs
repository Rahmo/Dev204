using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev204
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mod1

          
            //Mod1
            string FirstName = "Rahmo";
            string LastName = "Alzahrani";
            DateTime Birthdate = new DateTime(
                1987,06,28);
            string AddressLine1 = "5445 N Sheridan";
            string AddressLine2 = "Edgewater";
            string City = "Chicago";
            string State = "IL";
            string Province = "East";
            int Zip_Postal = 60640;
            string Country = "USA";

            Console.WriteLine("First Name :" + FirstName + "\n" +
                              "Last Name :" + LastName + "\n" +
                              "Birthdate :" + Birthdate + "\n" +
                              "Address Line 1 :" + AddressLine1 + "\n" +
                              "Address Line 2 :" + AddressLine2 + "\n" +
                              "City :" + City + "\n" +
                              "State :" + State + "\n" +
                              "Province :" + Province + "\n" +
                              "Zip'\'Postal :" + Zip_Postal + "\n" +
                              "Country :" + Country + "\n" 


                              );
            #endregion

            #region Mod2

           
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("XO");
                    }
                    else
                    {
                        Console.Write("OX");
                    }    
                }
                Console.Write("\n");
      } 
            #endregion


             Console.ReadLine(); // This line to keep the consol runninf to veiw the output.



        }
    }
}
