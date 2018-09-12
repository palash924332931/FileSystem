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
            
            FileService fs = new FileService();
            //fs.CreateFile();
            //fs.WriteInFile();
            //fs.ReadFile();
            //fs.GetFileDetails();

            FileOperationService operationService = new FileOperationService();
            operationService.FileComparision();
            operationService.CompareFileWriteDiff();

            Console.ReadLine();

        }
    }
}
