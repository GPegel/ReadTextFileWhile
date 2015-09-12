using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Values.txt");
            string Line = "";

            while (Line != null)
            {
                Line = myReader.ReadLine();
                if (Line != null)
                    Console.WriteLine(Line);
            }
            myReader.Close();
            Console.ReadLine();
        }
    }
}
//  To make use of StreamReader you need to add the System.IO namespace! And to make this project run,
//  set the property called 'Copy to Output Directory' of the Values.txt file to 'Copy Always'
