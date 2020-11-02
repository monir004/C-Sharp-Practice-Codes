using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result1 = new ResultInt { Success = true, Data = 5 };
            //Console.WriteLine(result1.Success);
            //Console.WriteLine(result1.Data);
            //var result2 = new ResultString { Success = false, Data = 100 };
            //Console.WriteLine(result2.Success);
            //Console.WriteLine(result2.Data);

            var result = new Result<int> { Success = true, Data = 4 };
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Data);

            var result2 = new Result<string> { Success = true, Data = "John" };

            var result3 = new Result<int, string> { Success = true, Data = 5, Data2 = "Monir" };

            Console.WriteLine(result3.Success + "  " + result3.Data + "  " + result3.Data2);

            var resultPrinter = new ResultPrinter();
            resultPrinter.Print(result);

            var resultPrinter2 = new ResultPrinter2();
            resultPrinter2.Print(result2);

        }
    }
    public class Result<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
    }
    public class Result<T,U>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public U Data2 { get; set; }
    }
    public class ResultPrinter2
    {
        public void Print<T>(Result<T> result)
        {
            Console.WriteLine("From ResultPrinter2 Class, Success = " + result.Success);
            Console.WriteLine("From ResultPrinter2 Class, Data = " + result.Data);
        }
    }
    public class ResultPrinter
    {
        public void Print(Result<int>result)
        {
            Console.WriteLine("From ResultPrinter Class, Success = "+ result.Success);
            Console.WriteLine("From ResultPrinter Class, Data = " +  result.Data);
        }
    }
    //public class ResultInt
    //{
    //    public bool Success { get; set; }
    //    public int Data { get; set; }
    //}
    //public class ResultString
    //{
    //    public bool Success { get; set; }
    //    public int Data { get; set; }
    //}
}
