using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class CountriesTextFile
    {
        public string ReadList()
        {

            
            String line;
            try
            {
                StreamReader sr = new StreamReader("C:\\beni\\lab_code\\country.txt");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
           //     Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
           


            return "selection1";
        }
        public string WriteList(string ipcountry)
        {

            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\beni\\lab_code\\country.txt",append:true);

                //Write a line of text
                sw.WriteLine(ipcountry);
                
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
           
            Console.WriteLine("This country has been saved!");
            return  "selection2";
        }
    }
}
