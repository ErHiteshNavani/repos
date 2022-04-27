using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public static class OperationsFactory<T>
    {
        public static IParser<T> GetParser(ParseType type)
        {
            switch (type)
            {
                case ParseType.Int:
                default:
                    return (IParser<T>) new IntParser();

            }
            throw new NotImplementedException();
        }

        public static IOperation<T> GetOperation(OperationType type)
        {
            switch (type)
            {
                case OperationType.Add:
                default:
                    return (IOperation<T>) new AddOperation();

            }
            throw new NotImplementedException();
        }
    }
}
