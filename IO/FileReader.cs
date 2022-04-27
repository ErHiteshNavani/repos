using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class FileReader : IReader
    {
        public string read()
        {
            return File.ReadAllText(ConfigurationManager.AppSettings["FilePath"]);
        }
    }
}
