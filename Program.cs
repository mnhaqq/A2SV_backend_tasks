﻿global using System;
using static Palindrome;
using static WordFrequencyCount;

class MainClass
{
    static void Main()
    {
        // Test palindrome
        Console.WriteLine("Tests for palindrome");
        TestPalindrome();
        Console.WriteLine("==================================");

        // Test Word Frequency Count
        Console.WriteLine("Tests for word frequency count");
        TestFrequencyCount();
        Console.WriteLine("==================================");
    }
}