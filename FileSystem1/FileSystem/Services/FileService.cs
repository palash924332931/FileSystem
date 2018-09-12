using FileSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.Services
{
    class FileService
    {
        private FileRepository _fileRepo;

        public FileService()
        {
            _fileRepo = new FileRepository();
        }
        public void CreateFile() {
            _fileRepo.fileName = "Palash_Kanti";
            _fileRepo.CreateFile();
        }

        public void ReadFile() {
            _fileRepo.ReadFile();
        }

        public void WriteInFile() {
            string inputVal = Console.ReadLine();
            _fileRepo.WriteValueInFile(inputVal);
        }

        public void GetFileDetails() {
            _fileRepo.GetFileDetailsInformation();
        }

    }
}
