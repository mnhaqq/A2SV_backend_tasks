using System.Text.Json;
using System.Text.Json.Serialization;

class Student
{
    public static int RollNumbers = 100;
    public string Name {get; set;}
    public int Age {get; set;}
    public double Grade {get; set;}
    
    [JsonInclude]
    public readonly int ID;

    public Student(string name, int age, double grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
        ID = RollNumbers;
        RollNumbers++;
    }

    public override string ToString()
    {
        return $"Student Name: {Name}\nRoll Number: {ID}\nAge: {Age}\nGrade: {Grade}\n";
    }
}

class StudentList<T> where T : Student
{
    List<T> Students;
    public StudentList()
    {
        Students = new List<T>();
    }
    public void AddStudent(T newStudent) 
    {
        Students.Add(newStudent);
    }

    public void DisplayStudents()
    {
        Console.WriteLine("Students\n");
        foreach (var student in Students)
        {
            Console.WriteLine(student);
        }
    }

    public void DisplayStudents(List<T> stds)
    {
        Console.WriteLine("Students\n");
        foreach (var student in stds)
        {
            Console.WriteLine(student);
        }
    }

    public List<T> Search(string name)
    {
        List<T> searchResult = new List<T>();

        IEnumerable<Student> searchQuery = 
            from student in Students
            where student.Name == name
            select student;

        foreach (T item in searchQuery)
        {
            searchResult.Add(item);
        }
        return searchResult;
    }

    public List<T> Search(int id)
    {
        List<T> searchResult = new List<T>();

        IEnumerable<Student> searchQuery = 
            from student in Students
            where student.ID == id
            select student;

        foreach (T item in searchQuery)
        {
            searchResult.Add(item);
        }
        return searchResult;
    }

    public string SerializeStudents()
    {
        return JsonSerializer.Serialize(Students);
    }

    public void Deserialize(string file)
    {
        try
        {
            string? jsonString = File.ReadAllText(file);
            if (jsonString != null) 
                Students = JsonSerializer.Deserialize<List<T>>(jsonString);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"{file} not found");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deserializing students: {ex.Message}");
        }
    }
}