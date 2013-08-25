//  4.Write methods that calculate the surface of a triangle by given:
//  Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
using System;

class CalculateSurfaceOfTriangle
{
    static void Main()
    {
        Console.WriteLine("Surface of triangle with altitude is {0}", CalculataWithAltitude(a: 2, ha: 3));
        Console.WriteLine("Surface of triangle with three sides is {0}", CalculataWithThreeSides(a: 2, b: 3, c: 4));
        Console.WriteLine("Surface of triangle with two sides and angle is {0}", CalculataWithTwoSidesAndAngle(a: 3, b: 4, angle: 90));
    }

    public static double CalculataWithAltitude(double a, double ha)
    {
        double surfaceOfTriangle = (a * ha) / 2;
        return surfaceOfTriangle;
    }

    public static double CalculataWithThreeSides(double a, double b, double c)
    {
        double oneHalfPerimeter = (a + b + c) / 2;
        double surfaceOfTriangle = Math.Sqrt((oneHalfPerimeter - a) * (oneHalfPerimeter - b) * (oneHalfPerimeter - c));
        return surfaceOfTriangle;
    }

    public static double CalculataWithTwoSidesAndAngle(double a, double b, double angle)
    {
        double surfaceOfTriangle = (a * b * Math.Sin(Math.PI * angle / 180)) / 2;
        return surfaceOfTriangle;
    }

}

