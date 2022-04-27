using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class AddOperation : IOperation<int>
    {
        public int operate(IEnumerable<int> inputs)
        {
            int op = 0;
            foreach (int item in inputs)
            {
                op += item;
            }

            return op;
        }
    }
}
