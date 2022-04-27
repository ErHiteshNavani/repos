using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class IntParser : IParser<int>
    {
        public IEnumerable<int> parse(string input)
        {
            var strings = input.Split(',');

            foreach (string s in strings)
            {
                yield return int.Parse(s);
            }
        }
    }
}
