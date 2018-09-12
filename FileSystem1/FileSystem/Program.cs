using FileSystem.Repositories;
using FileSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write(">");
            string input = System.Console.ReadLine();

            while (input != "quit" && input != "exit")
            {
                if (input == "cls" || input == "clear")
                {
                    System.Console.Clear();
                }
                else
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Ok");
                        //if (options.Parse(input))
                        //{
                        //    System.Console.WriteLine(handler.OutputMessage);
                        //}
                        //else
                        //{
                        //    System.Console.WriteLine("I didn't understand that command");
                        //}

                    }

                }

                System.Console.Write(">");
                input = System.Console.ReadLine();
            }


            FileService fs = new FileService();
            //fs.CreateFile();
            //fs.WriteInFile();
            //fs.ReadFile();
            //fs.GetFileDetails();

            //FileOperationService operationService = new FileOperationService();
            //operationService.FileComparision();
            //operationService.CompareFileWriteDiff();

            Console.ReadLine();

        }
    }
}
