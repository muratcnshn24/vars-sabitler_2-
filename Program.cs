using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vars_sabitler_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            var mC = new SampleClass(11, 22);
            Console.WriteLine($"x={mC.x}, y= {mC.y}");
            Console.WriteLine($"c1={SampleClass.c1}, c2= {SampleClass.c2}");


        }


    }

    class SampleClass
    {
        public int x;
        public int y;

        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public SampleClass(int p1, int p2)
        {
            x = p1;
            y = p2;

        }
    }



}



