using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyAllLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "none";
            IEnumerable<string> strings = new List<string> { "four", "one", "two", "three", "five" };
            if (strings.Take(3).Any(s => s.StartsWith("a")))
            {
                if (strings.Skip(1).Take(2).All(s => s.Length == 3))
                {
                    result = "red";
                }
                else
                {
                    result = "orange";
                }
            }
            else
            {
                if (strings.All(s => s.Length > 2))
                {
                    if (strings.OrderBy(s => s).Take(3).Any(s => s == "one"))
                    {
                        result = "yellow";
                    }
                    else
                    {
                        result = "green";
                    }
                }
                else
                {
                    result = "blue";
                }
            }

            Console.WriteLine(result);
        }
    }
}
