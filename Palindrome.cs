class Palindrome
{
    static bool CheckPalindrome(string str)
    {
        str = str.ToLower();
        string newStr = "";
        for (int i = 0; i < str.Length; i++)
        {
            if ((int)str[i] >= 97 && (int)str[i] <= 122)
            {
                newStr += str[i];
            }
        }
        
        int l = 0;
        int r = newStr.Length - 1;

        while (l < r)
        {
            if (newStr[l] != newStr[r]) return false;
            l++;
            r--;
        }
        return true;
    }

    public static void TestPalindrome()
    {
        // Testing with string which is a palindrome (return true)
        bool check = CheckPalindrome("madam");
        Console.WriteLine(check);        

        // Testing with non palindrome (return false)
        check = CheckPalindrome("haqq");
        Console.WriteLine(check);

        // Testing palindrome with different cases, whitespace and punctuations (return true)
        check = CheckPalindrome("M, a   dA .! M");
        Console.WriteLine(check);

        // Testing non palindrome with punctuation and whitespace (return false)
        check = CheckPalindrome("h  , a!!! qq");
        Console.WriteLine(check);

        // Testing palindrome digits (return true)
        check = CheckPalindrome("1221");
        Console.WriteLine(check);
    }
}

