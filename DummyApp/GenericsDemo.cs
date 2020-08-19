using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyApp
{
    public class GenericsDemo
    {
        static void Main(string[] args)
        {
            Test<int> intTest = new Test<int>();
            intTest.value = 11;

            Test<string> stringTest = new Test<string>();
            stringTest.value = "Mahesh";

            Console.WriteLine(intTest.value);
            Console.WriteLine(stringTest.value);

            Test1 test1 = new Test1();
            test1.DisplayData<string>("String", "Hi");
            test1.DisplayData<int>("Int", 100);

            Console.ReadLine();
        }
    }

    class Test<T>
    {
        private T data;
        public T value
        {
            get { return this.data; }
            set { this.data = value; }
        }
    }

    class Test1
    {
        public void DisplayData<T>(string msg, T typeT)
        {
            Console.WriteLine($"Message {msg} and type is {typeT}");
        }
    }
}
