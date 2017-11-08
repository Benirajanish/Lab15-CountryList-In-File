using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class CountryMainClass
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Countries Maintenance Application!");

            bool success = true;
            while (success==true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("1-See the list of countries");

                Console.WriteLine("2-Add a country");

                Console.WriteLine("3-Exit\n");


                Console.WriteLine("Please enter menu number  :");
                string option = Console.ReadLine();
                Console.WriteLine("\n");
                bool success1 = int.TryParse(option, out int option1);
                

                CountriesTextFile str = new CountriesTextFile();
                if (option1 == 1)
                {


                    str.ReadList();
                }
                else if (option1 == 2)
                {
                    Console.WriteLine("Enter Country :");
                    string country = Console.ReadLine();

                    str.WriteList(country);
                }
                else
                {
                     success = false;
                    Console.WriteLine("Buh - bye");

                }
            }
            
        }

    }
}
