class WordFrequencyCount
{
    static Dictionary<string, int> FrequencyCount(string str)
    {   
        str = str.ToLower();

        string newStr = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (((int)str[i] >= 97 && (int)str[i] <= 122) || str[i] == ' ')
            {
                newStr += str[i];
            }
        }
   
        string[] arr = newStr.Split(" ");

        Dictionary<string, int> dic = [];
        foreach (var item in arr)
        {
            if (item == "" || item == " ") continue;
            if (dic.ContainsKey(item)) dic[item]++;
            else dic[item] = 1;
        }
        return dic;
    }

    public static void TestFrequencyCount()
    {
        Dictionary<string, int> dic = FrequencyCount("haqq haqq haqq farad farad george");
        foreach ( KeyValuePair<string, int> kvp in dic)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        Console.WriteLine();

        // Testing with whitespace and punctuation
        dic = FrequencyCount("haqq!!! haqq  !,!,!, haqq farad,,,, farad,,, george");
        foreach ( KeyValuePair<string, int> kvp in dic)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        Console.WriteLine();

        // Testing with empty string
        dic = FrequencyCount("   ");
        foreach ( KeyValuePair<string, int> kvp in dic)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

}