using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Parallelogram
    {
        double a;
        double b;
        double angleDegrees;

        public Parallelogram(double aa, double bb, double angle)
        {
            this.a = aa;
            this.b = bb;
            this.angleDegrees = angle;
        }

        public double getA() { return a; }
        public double getB() { return b; }
        public double getAngle() { return angleDegrees; }
        public void setA(double a) { this.a = a; }
        public void setB(double b) { this.b = b; }
        public void setAngle(double angle) { this.angleDegrees = angle; }

        public double calculateHeight()
        {
            double angleRadians = angleDegrees * Math.PI / 180;
            return b * Math.Sin(angleRadians);
        }

        public double calculateSquare()
        {
            double height = calculateHeight();
            return a * height;
        }
    }
}
