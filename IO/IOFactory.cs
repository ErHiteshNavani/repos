using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class IOFactory
    {
        public static IReader GetReader(IOType type) { 
            switch (type)
            {
                case IOType.File:
                default:
                    return new FileReader();

            }
            throw new NotImplementedException();
        }

        public static IWriter<string> GetWriter(IOType type)
        {
            switch (type)
            {
                case IOType.Console:
                default:
                    return new ConsoleWriter();

            }
            throw new NotImplementedException();
        }
    }
}
