class GradeCalculator
{
    public static void GradeCalc()
    {
        // Take name input
        string? name;
        while (true)
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            if (name is not null && name.Length > 0) break;
        }
        

        // Take number of subjects input
        string? numberOfSubjects;
        int subjectCount;
        while (true)
        {
            Console.Write("Enter number of subjects: ");
            numberOfSubjects = Console.ReadLine();
            if (int.TryParse(numberOfSubjects, out subjectCount))
            {
                Console.WriteLine($"{numberOfSubjects} subjects");
                break;
            }
            else 
                Console.WriteLine("Invalid Input! Try again!");
        }
        

        // Take grades for each subject
        Dictionary<String, int> grades = [];
        string? subjectName, subjectGrade;
        int grade;
        // string? subjectGrade
        for (int i = 0; i < subjectCount; i++)
        {
            while (true)
            {
                Console.Write($"Enter subject {i}: ");
                subjectName = Console.ReadLine();
                if (subjectName is not null && subjectName.Length > 0) break;
            }

            while (true)
            {
                Console.Write($"Enter grade for {subjectName} (Between 0 and 100): ");
                subjectGrade = Console.ReadLine();

                if (int.TryParse(subjectGrade, out grade) && grade >= 0 && grade <= 100)
                    break;
                else 
                    Console.WriteLine("Invalid Input! Try again"); 
            }
            if (subjectName is not null)
                grades[subjectName] = grade;     
        }

        Console.WriteLine();

        // Calculate average
        Dictionary<string, int>.ValueCollection arr = grades.Values;
        decimal average = CalcAverage(arr);

        // Output Results
        Console.WriteLine($"Your name is : {name}");
        Console.WriteLine($"Number of subjects taken: {subjectCount}");

        foreach (KeyValuePair<string, int> kvp in grades)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        Console.WriteLine($"Average grade: {average}");
    }

    static decimal CalcAverage(Dictionary<string, int>.ValueCollection arr)
    {
        int length = 0;
        int sum = 0;

        foreach (int grade in arr)
        {
            sum += grade;
            length++;
        }

        return sum / length;
    }
}