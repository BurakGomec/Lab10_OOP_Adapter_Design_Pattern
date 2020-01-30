using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_design_pattern
{
    class GeometricShapeObjectAdapter : Shape
    {
        private Triangle triangle;
        private Triangle x;

        public GeometricShapeObjectAdapter(Triangle x)
        {
            this.x = x;
        }

        public void draw()
        {
            Console.WriteLine("Drawing Triangle with area: " + x.area());
        }
    }
}
