using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class Parallelogram
    {
        private double a;
        private double b;
        private double angleDegrees;

        public Parallelogram(double aa, double bb, double angle)
        {
            SetA(aa);
            SetB(bb);
            SetAngle(angle);
        }

        public Parallelogram()
        {
            this.a = 1;
            this.b = 1;
            this.angleDegrees = 1;
        }

        public double GetA() { return a; }
        public double GetB() { return b; }
        public double GetAngle() { return angleDegrees; }
        public void SetA(double a)
        {
            if (a <= 0)
                throw new ArgumentException("Side length must be greater than zero.");
            this.a = a;
        }
        public void SetB(double b)
        {
            if (b <= 0)
                throw new ArgumentException("Side length must be greater than zero.");
            this.b = b;
        }
        public void SetAngle(double angle)
        {
            if (angle <= 0 || angle >= 180)
                throw new ArgumentException("Angle must be between 0 and 180 degrees.");
            this.angleDegrees = angle;
        }

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
