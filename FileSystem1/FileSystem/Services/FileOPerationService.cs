using FileSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.Services
{
    class FileOperationService
    {
       private FileOperationRepository _fileOperationRepo;
        public FileOperationService() {
            _fileOperationRepo= new FileOperationRepository();
        }

        public void FileComparision() {
           string file1 = @"d:\Files\H\Palash_Kanti.txt";
            string file2= @"d:\Files\Palash_Kanti.txt";
            var result=_fileOperationRepo.FileCompare(file1, file2);
            Console.WriteLine("File Comparision result"+result);
        }

        public void CompareFileWriteDiff()
        {
            string file1 = @"d:\Files\H\Palash_Kanti.txt";
            string file2 = @"d:\Files\Palash_Kanti.txt";
           _fileOperationRepo.CompareFileWriteDiff(file1, file2);
        }

    }
}
