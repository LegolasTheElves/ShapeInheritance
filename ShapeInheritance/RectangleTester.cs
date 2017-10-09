using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInheritance
{

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Console.Write("Enter width:");
            int w = Convert.ToInt32(Console.ReadLine());
            Rect.setWidth(w);
            Console.Write("Enter width:");
            int h = Convert.ToInt32(Console.ReadLine());
            Rect.setHeight(h);

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.ReadKey();
        }
    }
}