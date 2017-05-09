using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class MyClass
    {
        string Message;

        public MyClass()
        {
            Message = "Hello World";
        }

        public void PrintMessage()
        {
            Console.WriteLine(Message);
        }

        // 소멸자
        ~MyClass()
        {
            Console.Write("소멸자 호출");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyTest = new MyClass();
            // MyTest.PrintMessage();

        }
    }
}
