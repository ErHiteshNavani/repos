using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public interface IParser<T>
    {
        IEnumerable<T> parse(string input);
    }
}
