using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FindArea
    {
        public static double CircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше нуля");
            }
            double circle_area = Math.PI * Math.Pow(radius, 2);

            return circle_area;
        }

        public static double TriangleArea(double first_side, double second_side, double third_side)
        {
            if (first_side <= 0 || second_side <= 0 || third_side <= 0)
            {
                throw new ArgumentException("Стороны должны быть больше нуля");
            }
            double half_perimeter = (first_side + second_side + third_side) / 3;
            double triangle_area = Math.Sqrt(half_perimeter * (half_perimeter - first_side) *
                (half_perimeter - second_side) * (half_perimeter * third_side));
            return triangle_area;
        }

        public static bool TriangleCheck(double first_side, double second_side, double third_side)
        {
            if (first_side <= 0 || second_side <= 0 || third_side <= 0)
            {
                throw new ArgumentException("Стороны должны быть больше нуля");
            }

            double hip = Math.Max(Math.Max(first_side, second_side), third_side);

            if (hip * hip == first_side * first_side || hip * hip == second_side * second_side || hip * hip == third_side * third_side)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}


