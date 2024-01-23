using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zrakoplov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov zrakoplov = new Zrakoplov("Airbus", 2000, 6000, 800, 0, 0);

            double udaljenost = zrakoplov.plan_leta(0, 200);

            Console.WriteLine(zrakoplov.ToString());

            Console.Write("Plan leta: " + udaljenost);

            Console.ReadKey();
        }
    }
}
