using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazrediiObjekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sport Nogomet = new Sport("Nogomet");
            Sport Vaterpolo = new Sport("Vaterpolo", true);
            Sport Curling = new Sport("Curling", false, 4);
        }
    }
}
