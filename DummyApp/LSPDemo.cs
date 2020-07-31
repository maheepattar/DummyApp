using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyApp
{
    public class LSPDemo
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Calculator sumCalculator = new SumCalculator(numbers);
            Console.WriteLine("Sum from Sum calculator : " + sumCalculator.Calculate());

            Calculator evenNumberCalcular = new EvenNumberCalcular(numbers);
            Console.WriteLine("Sum from Even Sum calculator : " + evenNumberCalcular.Calculate());

            Console.ReadLine();
        }
    }

    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) : base(numbers)
        {
        }

        public override int Calculate()
        {
            return this._numbers.Sum();
        }
    }

    public class EvenNumberCalcular : Calculator
    {
        public EvenNumberCalcular(int[] numbers) : base(numbers)
        {
        }
        public override int Calculate()
        {
            return _numbers.Where(s => s % 2 == 0).Sum();
        }
    }

    public abstract class Calculator
    {
        protected readonly int[] _numbers;
        public Calculator(int[] nums)
        {
            this._numbers = nums;
        }

        public abstract int Calculate();
    }
}
