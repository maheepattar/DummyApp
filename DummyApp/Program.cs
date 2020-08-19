using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DummyApp
{
    class Program
    {
        static int temp = 0, steps = 1;
        static void Main(string[] args)
        {

            int num = 10;
            FuncV(num);
            Console.WriteLine(num + ",");
            FuncR(ref num);
            Console.WriteLine(num);
            Console.ReadKey();
        }

        static void FuncV(int num)
        {
            num = num + 10;
            Console.WriteLine(num+ ",");
        }

        static void FuncR(ref int num)
        {
            num = num + 10;
            Console.WriteLine(num + ",");
        }

        private static void LinqQueris()
        {
            UserData userData = new UserData();
            int thirdHighSal = (from u in userData.GetUserData()
                                orderby u.Salary descending
                                select u.Salary).ElementAt(0);

            var b = (from k in userData.GetUserData()
                         // group k by k.Salary into l
                     select k).Distinct();
        }

        static int LeaderSorted(int[]  arr)
        {
            int leader = 1 , result = (arr.Length /2 ) + 1, returnValue = -1;
            int[] lArry = new int[arr.Length + 1];
            lArry[lArry.Length - 1] = -1;
            for (int i = 0; i < lArry.Length - 1; i++)
            {
                lArry[i] = arr[i];
            }
            for (int i = 0; i < lArry.Length -1; i++)
            {
                if (lArry[i] == lArry[i+1])
                {
                    leader++;

                    if (leader >= result)
                    {
                        returnValue = 1;
                        break;
                    } 
                    else
                        continue;
                }
            }

            

            return returnValue;
        }

        static void solution(int[] A, int X)
        {
            int N = A.Length;
            if (N == 0)
            {
                Console.WriteLine("-1");
            }
            int l = 0;
            int r = N - 1;
            while (l < r)
            {
                int m = (l + r) / 2;
                if (A[m] > X)
                {
                    r = m - 1;
                }
                else
                {
                    l = m;
                }
                //}
                if (A[m] == X)
                {
                    Console.WriteLine(l);
                    return;
                }
            }

            Console.WriteLine("-1");
        }

        static void RightRotation()
        {
            int[] arrayToRotate = { 3, 5, 7, 9 };
            Console.WriteLine("Array before rotating  " + string.Join(", ", arrayToRotate));
            for (int s = 0; s < steps; s++)
            {
                for (int k = 0; k < arrayToRotate.Length - 1; k++)
                {
                    for (int j = 0; j < arrayToRotate.Length - 1; j++)
                    {
                        temp = arrayToRotate[j];
                        arrayToRotate[j] = arrayToRotate[j + 1];
                        arrayToRotate[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Array after rotating towrds right direction - " + string.Join(", ", arrayToRotate));
        }

        static void LeftRotation()
        {
            int[] arrayToRotate = { 3, 5, 7, 9 };
            Console.WriteLine("Array before rotating  " + string.Join(", ", arrayToRotate));
            for (int s = 0; s < steps; s++)
            {
                for (int k = 0; k < arrayToRotate.Length - 1; k++)
                {
                    for (int j = arrayToRotate.Length - 1; j > 0; j--)
                    {
                        temp = arrayToRotate[j];
                        arrayToRotate[j] = arrayToRotate[j-1];
                        arrayToRotate[j - 1] = temp;
                    }
                }
            }

            Console.WriteLine("Array after rotating towrds left direction  - " + string.Join(", ", arrayToRotate.Select(a => a.ToString())));
        }
    }

    class Rectangle
    {
        private decimal _width;
        private decimal _height;
        public virtual void SetWidth(int width)
        {
            this._width = width;
        }

        public virtual void SetHieght(int height)
        {

            this._height = height;
        }

        public virtual decimal GetArea()
        {
            return this._width * this._height;
        }
    }

    class Square : Rectangle
    {

    }

    class TestClass
    {
        static int s;
        static TestClass()
        {
            s = 8;
        }

        private int a = 0;
        public TestClass()
        {
            this.a = 7;
        }

        public TestClass(int a)
        {
            this.a = a;
        }

        void Print()
        {
            Console.WriteLine(a);
        }
    }
}
