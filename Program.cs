using System;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vec1 = new Vector(1, 1, 1);
            Vector vec2 = new Vector(1, 1, 1);

            Vector sum = new Vector { VecSum = $"{vec1 + vec2}" };
            Console.WriteLine(sum);
        }
        private string VecSum;
        public override string ToString() => VecSum;
}
    }
