using System;
using System.IO;
using System.Text;

namespace Log_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");

            if (!File.Exists("log.txt"))
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create("log.txt"))
                {
                }
            }
            StreamWriter streamWriter = new StreamWriter("log.txt", true, Encoding.ASCII);
            //Write a line of text
            streamWriter.WriteLine(DateTime.Now.ToString() + " - open file by " + Environment.UserName);
            //Close the file


            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Change data\n2. Exit");
                Console.Write("Your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        //Write a line of text
                        streamWriter.WriteLine(DateTime.Now.ToString() + " - change file by " + Environment.UserName);
                        break;
                    case 2:
                        //Write a line of text
                        streamWriter.WriteLine(DateTime.Now.ToString() + " - exit from file by " + Environment.UserName);
                        //Close the file
                        streamWriter.Close();
                        return;

                }
            }


        }
    }
}
