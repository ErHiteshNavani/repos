using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;
using Operations;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader reader = IOFactory.GetReader(IOType.File);
            string fileData = reader.read();

            IParser<int> parser = OperationsFactory<int>.GetParser(ParseType.Int);
            IEnumerable<int> ints= parser.parse(fileData);

            IOperation<int> operation = OperationsFactory<int>.GetOperation(OperationType.Add);
            int output = operation.operate(ints);

            IWriter<string> op = IOFactory.GetWriter(IOType.Console);
            op.Send(output.ToString());

            Console.ReadKey();
        }
    }
}
