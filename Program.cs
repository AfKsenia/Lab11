using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите К");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine( "Введите b");
            double b = Convert.ToDouble(Console.ReadLine());
            Equation equation = new Equation(k, b);
            equation.Root();

            Console.ReadKey();
        }
    }
    public struct Equation
    {
        public Equation(double k, double b)
        {
            this.b = b;
            this.k = k;

        }
        public double k;
        public double b;
        public void Root()
        {
            Console.WriteLine("X={0}", -b/k);
        }

    }
}
