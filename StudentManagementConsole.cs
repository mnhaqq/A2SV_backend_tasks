class StudentManagementConsole
{
    StudentList<Student> studentList = new StudentList<Student>();

    public void StartConsole()
    {
        studentList.Deserialize("students.json");

        Console.WriteLine("Welcome To Student Management System");
        Console.WriteLine("1. Add New Student\n2. Search For Student(ID)\n3. Search For Student(Name)\n4. View Students");
        Console.Write("Select option: ");

        string? optionInput = Console.ReadLine();
        int option;
        if (optionInput != null)
            option = int.Parse(optionInput);
        else 
            option = 4;

        if (option == 1) AddStudent();
        else if (option == 2) SearchStudentID();
        else if (option == 3) SearchStudentName();
        else if (option == 4) ListStudents();
        else Console.WriteLine("Invalid Input");
    }

    public void AddStudent()
    {    
        Console.WriteLine("Add New Student");
        Console.Write("Enter student name: ");
        string? Name = Console.ReadLine();  
        if (Name == null) Name = "No Name";

        Console.Write("Enter student age: ");
        string? AgeInput = Console.ReadLine();
        int Age;
        if (AgeInput != null) Age = int.Parse(AgeInput);
        else Age = 0;
        
        Console.Write("Enter student grade: ");
        string? GradeInput = Console.ReadLine();
        double Grade;
        if (GradeInput != null) Grade = double.Parse(GradeInput);
        else Grade = 0.0;

        Student student = new Student(Name, Age, Grade);
        studentList.AddStudent(student);
        studentList.SerializeStudents();
    }

    public void SearchStudentName()
    {
        Console.WriteLine("Search Student By Name");
        Console.Write("Enter student name: ");
        string? Name = Console.ReadLine();  
        if (Name == null) Name = "No Name";

        studentList.DisplayStudents(studentList.Search(Name));
    }

    public void SearchStudentID()
    {
        Console.WriteLine("Search Student By ID");
        Console.Write("Enter student ID: ");
        string? idInput = Console.ReadLine();  
        int id;
        if (idInput != null) id = int.Parse(idInput);
        else id = 100;
        
        studentList.DisplayStudents(studentList.Search(id));
    }

    public void ListStudents()
    {
        studentList.DisplayStudents();
    }
}