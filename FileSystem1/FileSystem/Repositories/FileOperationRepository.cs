using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.Repositories
{
    class FileOperationRepository
    {
        public string ShowFileContentDiff()
        {
            return "";
        }

        public bool FileCompare(string file1, string file2, int bufferSize = 8192) {
            if (new FileInfo(file1).Length != new FileInfo(file2).Length) return false;
            return (File.ReadAllBytes(file1).SequenceEqual(File.ReadAllBytes(file2)));
        }

        public void CompareFileWriteDiff(string file1, string file2)
        {
            String directory = @"D:\Files\Result";
            //String[] linesA = File.ReadAllLines(Path.Combine(directory, "FileA-Database.txt"));
            //String[] linesB = File.ReadAllLines(Path.Combine(directory, "FileB-Database.txt"));

            String[] linesA = File.ReadAllLines(file1);
            String[] linesB = File.ReadAllLines(file2);

            IEnumerable<String> onlyB = linesB.Except(linesA);
            IEnumerable<String> onlyA = linesA.Except(linesB);
            if (!File.Exists(Path.Combine(directory, "Result.txt"))) {
                System.IO.Directory.CreateDirectory(directory);
                //File.Create(Path.Combine(directory, "Result.txt"));
            }
            File.WriteAllLines(Path.Combine(directory, "Result.txt"), onlyB);
            File.WriteAllLines(Path.Combine(directory, "Result2.txt"), onlyA);
            Console.WriteLine("File Comparision completed");
        }

    }
}
