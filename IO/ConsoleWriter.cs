using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class ConsoleWriter : IWriter<string>
    {
        public void Send(string s)
        {
            Console.WriteLine(s);
        }
    }
}
