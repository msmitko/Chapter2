using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0.1259633;
            double x = 0.1259630;
            double Comp = Math.Sign(x.CompareTo(y));
            Console.WriteLine("If y>x(-1) if y=x(0) if y<x (1) >>> : {0}", Comp);
        }
    }
}