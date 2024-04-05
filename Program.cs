global using System;
using static Palindrome;
using static WordFrequencyCount;
using static GradeCalculator;
using static Shape;

class MainClass
{
    static void Main()
    {
        Circle circle = new Circle("New Circle", 3.5);
        Rectangle rectangle = new Rectangle("New Rectangle", 4, 3);
        Triangle triangle = new Triangle("New Triangle", 5.5, 3);

        
        PrintShapeArea(circle);
        PrintShapeArea(rectangle);
        PrintShapeArea(triangle);
    }
}