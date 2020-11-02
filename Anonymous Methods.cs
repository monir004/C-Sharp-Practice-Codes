using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Methods
{
    delegate void Operation(int num);
    delegate int Operation2(int num);
    class Program
    {
        static void Main(string[] args)
        {
            //Operation op = delegate (int num) { Console.WriteLine("{0} * 2 = {1}", num, num * 2); };
            Operation op =  num => { Console.WriteLine("{0} * 2 = {1}", num, num * 2); };
            //Operation op = Double;
            Operation2 op2 = delegate (int num){return num * num;};
            op(2);
            int res = op2(5);
            Console.WriteLine(res);
            Action<int> op3 = num=> { Console.WriteLine("{0} * 2 = {1}", num, num * 2); };
            op3(6);
            Func<int, int> DoubleNumber = x => { return x * 2; };
            Console.WriteLine(DoubleNumber(9));

        }
        static void Double(int num)
        {
            Console.WriteLine("{0} * 2 = {1}", num, num * 2);
        }
    }
}
