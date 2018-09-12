using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.Repositories
{
    class FileRepository
    {
        public string fileName;
        public readonly string fileLocation = @"d:\";
        public FileRepository() {

        }

        public string CreateFile() {
            if (string.IsNullOrEmpty(fileName))
            {
                Console.WriteLine("Please input the file name.");
                fileName = Console.ReadLine();
            }
           var filePath = fileLocation + fileName + ".txt";
            FileStream fs = null;
            if (!File.Exists(filePath))
            {
                using (fs = File.Create(filePath))
                {
                    Console.WriteLine("File created successfully...");
                }
            }
            else
            {
                Console.WriteLine("File already exists");
            }
            return "Success";
        }

        public object ReadFile() {
            string rec;
            using (TextReader tr = new StreamReader(fileLocation + fileName + ".txt"))
            {               
                rec = tr.ReadLine();
                    //Console.WriteLine(tr.ReadLine());
            }
            Console.WriteLine(rec);
            return rec;
        }

        public void WriteValueInFile(string data)
        {
            using (StreamWriter sw = new StreamWriter(fileLocation + fileName + ".txt"))
            {
                sw.Write(data);
            }
        }

        public void GetFileDetailsInformation() {
            FileInfo oFileInfo = new FileInfo(fileLocation + fileName + ".txt");
            Console.WriteLine("My File's Name: \"" + oFileInfo.Name + "\"");
            DateTime dtCreationTime = oFileInfo.CreationTime;
            Console.WriteLine("Date and Time File Created: " + dtCreationTime.ToString());
            Console.WriteLine("myFile Extension: " + oFileInfo.Extension);
            Console.WriteLine("myFile total Size: " + oFileInfo.Length.ToString());
            Console.WriteLine("myFile filepath: " + oFileInfo.DirectoryName);
            Console.WriteLine("My File's Full Name: \"" + oFileInfo.FullName + "\"");
        }

    }
}
