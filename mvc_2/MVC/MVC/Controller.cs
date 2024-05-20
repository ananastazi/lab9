using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class ControllerParallelogram
    {
        public double Question1(double a, double b, double angle)
        {
            var parallelogram = new Parallelogram(a, b, angle);
            return parallelogram.calculateHeight();
        }

        public double Question2(double a, double b, double angle)
        {
            var parallelogram = new Parallelogram(a, b, angle);
            return parallelogram.calculateSquare();
        }
    }
}
