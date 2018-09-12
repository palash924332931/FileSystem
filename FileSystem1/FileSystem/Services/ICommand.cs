using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.Services
{
    interface ICommand
    {
        long Add(long x);
        long Sub(long x);
        long Cal();
    }
}
