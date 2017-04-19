using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace TConsoleApp
{
    struct MyStruct
    {
        internal void Fun() { }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Test01();
            //Test02();
            //Test03(); // test IDisposable
            LambdaTest();
        }

        private static void Test01()
        {
            object o = 3.14;
            double d = (double) o;
            var i = 90;
        }

        private static void Test02()
        {
            ClassA a = new ClassA();
            lock (a)
            {
                
            }
            var b = new MyClassA();

            var s = new MyStruct();
            s.Fun();
            MyStruct s1;
            s1.Fun();
        }

        private static void Test03()
        {
            ADisp a = new ADisp();
            try
            {
                a.DoSmth();
            }
            finally
            {
                a.Dispose();
            }
        }

        private static void LambdaTest()
        {
            Func<int, double> expr = x => (double)x / 2;
        }
    }
}

