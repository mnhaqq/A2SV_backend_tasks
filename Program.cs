global using System;
using static Palindrome;
using static WordFrequencyCount;
using static GradeCalculator;
using static Shape;

class MainClass
{
    static void Main()
    {
        DayTwo();
    }

    static void DayTwo()
    {
        Circle circle = new Circle("New Circle", 3.5);
        Rectangle rectangle = new Rectangle("New Rectangle", 4, 3);
        Triangle triangle = new Triangle("New Triangle", 5.5, 3);

        
        PrintShapeArea(circle);
        PrintShapeArea(rectangle);
        PrintShapeArea(triangle);
    }

    static void DayOne()
    {
        // Test palindrome
        Console.WriteLine("Tests for palindrome");
        TestPalindrome();
        Console.WriteLine("==================================");

        // Test Word Frequency Count
        Console.WriteLine("Tests for word frequency count");
        TestFrequencyCount();
        Console.WriteLine("==================================");

        // Run grade calculator console application
        Console.WriteLine("Grade calculator console application");
        GradeCalc();
    }
}