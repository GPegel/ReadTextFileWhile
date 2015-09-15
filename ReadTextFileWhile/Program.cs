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

            try
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

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file. Are you sure the Directory exists?");
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file. Are you sure the File exists?");

            }


            catch (Exception e)
            {
                Console.WriteLine("Oh oh...now you broke it...!!! : {0}", e.Message);

            }

            finally {
                //  Perform any cleanup to roll back the data or close connections
                //  to files, databases, network etc.
            }


            Console.ReadLine();
        }
    }
    }
//  To make use of StreamReader you need to add the System.IO namespace! And to make this project run,
//  set the property called 'Copy to Output Directory' of the Values.txt file to 'Copy Always'
