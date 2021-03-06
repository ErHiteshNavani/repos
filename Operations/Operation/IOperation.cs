using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public interface IOperation<T>
    {
        T operate(IEnumerable<T> inputs);
    }

}
