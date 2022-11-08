using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecuatie
{
    class Ecuatie
    {
        double a, b, c;
        public Ecuatie(string ecuatie)
        {
            a = double.Parse(ecuatie.Split('x')[0]);

            ecuatie = ecuatie.Substring(ecuatie.IndexOf('x') + 3);
            b = double.Parse(ecuatie.Split('x')[0]);

            ecuatie = ecuatie.Substring(ecuatie.IndexOf('x') + 1);
            c = double.Parse(ecuatie.Split('x')[0]);
        }
        public double Delta()
        {
            double delta = (b * b) - 4 * a * c;
            if (delta < 0)
            {
                throw new DeltaException("Delta negativ");
            }
            return delta;
        }
        public string Radacini()
        {
            if (Delta() == 0)
            {
                return $"{ -(b / (2 * a)) } { -(b / (2 * a)) }";
            }
            else if (Math.Sqrt(Delta()) * Math.Sqrt(Delta()) == Delta())
            {
                return $"{ (-b + Math.Sqrt(Delta())) / (2 * a) } { (-b - Math.Sqrt(Delta())) / (2 * a) }";
            }
            else
            {
                throw new DeltaException("Delta nu este patrat perfect");
            }
        }
        public override string ToString()
        {
            return $"a:{a} b:{b} c:{c} D:{Delta()} R1R2:{Radacini()}";
        }

    }
}
