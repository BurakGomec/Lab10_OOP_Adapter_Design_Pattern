using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_design_pattern
{
    class Triangle : IGeometricShapeAdapter
    {
        private double v1;
        private double v2;
        private double v3;

        public double Kenar1
        {
            get
            {
                return Kenar1;
            }
            set
            {
                Kenar1 = value;
            }
        }
        public double Kenar2
        {
            get
            {
                return Kenar2;
            }
            set
            {
                Kenar2 = value;
            }
        }
        public double Kenar3
        {
            get
            {
                return Kenar3;

            }
            set
            {
                Kenar3 = value;
            }
        }

       
        public Triangle(int v1,int v2, int v3)
        {
            this.v1 = v1;

            this.v2 = v2;

            this.v3 = v3;
        }

        public double area()
        {
            double s= (v1 + v2 + v3) / 2;
            
            double A = Math.Sqrt(s * (s - v1) * (s - v2) * (s - v3));
            
            return A;
        }
        public void drawShape()
        {
            Console.WriteLine("Drawing Triangle with area: " + area());

        }

    }


    }

