using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //delegate void MyDelegate();
    //delegate void MyDelegate(string name);
    delegate void Operation(int num);
    class Program
    {
        static void Main(string[] args)
        {
            //MyDelegate del = new MyDelegate(sayHello);
            //MyDelegate del = GiveMeMyDelegate();

            //MyDelegate del2 = sayHello;
            //Test(del);
            //Double(2);
            Operation op = Double;
            ExecuteOperation(2, op);
            op = Triple;
            ExecuteOperation(2, op);
            op = op-Triple;
            op += Double;
            op += Triple;
            ExecuteOperation(2, op);


            //del.Invoke();
            //del();
            //del2();
            //sayHello();
        }
        static void sayHello(string name)
        {
            Console.WriteLine("Hey there, {0}!", name);
        }

        public static void ExecuteOperation(int num, Operation operation)
        {
            operation(num);
        }

        //static void sayHello()
        //{
        //    Console.WriteLine("Hey there!");
        //}

        static void Double(int num)
        {
            Console.WriteLine("{0} * 2 = {1}", num, num * 2);
        }
        static void Triple(int num)
        {
            Console.WriteLine("{0} * 3 = {1}", num, num * 3);
        }
        
        //static void Test(MyDelegate del)
        //{
        //    del("John");
        //}

        //static MyDelegate GiveMeMyDelegate()
        //{
        //    return new MyDelegate(sayHello);
        //}
    }
}
