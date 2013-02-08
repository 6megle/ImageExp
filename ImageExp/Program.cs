using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageExp
{
    class Program
    {
        abstract class AffineObject
        {
            public double Position { get; protected set; }
            public abstract List<double> Draw();
        }

        class Circle : AffineObject
        {            
            //public overridedouble Position { get; private set; }
            public double Raduis { get; private set; }

            public Circle(double position, double radius)
            {
                Position = position; Raduis = radius;
            }

            public override List<double> Draw()
            {
                throw new NotImplementedException();
            }            
        }

        static void Main(string[] args)
        {
            var c = new Circle(1.0,1.0);
            Console.WriteLine("hello world");
        }
    }
}
