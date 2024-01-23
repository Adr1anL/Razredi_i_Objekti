using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zrakoplov
{
    internal class Tocka
    {
        private double m_x;
        private double m_y;

        public double x { get => m_x; set => m_x = value; }
        public double y { get => m_y; set => m_y = value; }

        public override string ToString()
        {
            return ("x = " + x + "\ny = " + y);
        }

        public Tocka(double x = 1, double y = 1)
        {
            m_x = x;
            m_y = y;
        }

        public double udaljenost(Tocka T)
        {
            return Math.Sqrt(Math.Pow((m_x - T.x), 2) + Math.Pow((m_y - T.y), 2));
        }
    }
}