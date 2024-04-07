class ConsoleApplication
{
    TaskManager taskManager = new TaskManager {};
    public async Task StartConsole()
    {

        Console.WriteLine("Welcome To Your Console Application");
        Console.WriteLine("1. View Tasks\n2. Add New Task");
        Console.Write("Select an option: ");

        string? optionInput = Console.ReadLine();
        int option;
        if (optionInput != null)
            option = int.Parse(optionInput);
        else 
            option = 1;

        if (option == 1) await this.ViewTasks();
        else if (option == 2) await this.AddTask();
        else 
        {
            Console.WriteLine("Invalid Input");
        }
    }

    public async Task ViewTasks()
    {
        await taskManager.ReadTasksFromCSV();
        taskManager.DisplayTasks(taskManager.Tasks);
    }

    public async Task AddTask()
    {
        Console.Write("Enter Task Name: ");
        string? name = Console.ReadLine();  
        if (name == null) name = "Task Name";

        Console.WriteLine("Describe Task");
        string? description = Console.ReadLine();
        if (description == null) description = "Task Description";

        Console.WriteLine("Task Category");
        Console.WriteLine("1. Personal\n2. Work\n3. Kids");
        Console.Write("Select an option: ");
        string? categoryInput = Console.ReadLine();
        TaskCategories category;
        if (categoryInput != null)
            category = (TaskCategories)(int.Parse(categoryInput) - 1);
        else category = TaskCategories.Personal;

        Console.Write("Have you completed the task (Y/N): ");
        string? isCompletedInput = Console.ReadLine();
        bool isCompleted;
        if (isCompletedInput != null && isCompletedInput.ToLower().Equals("y")) isCompleted = true;
        else isCompleted = false;
        
        NewTask newTask = new NewTask 
        {
            Name = name,
            Description = description,
            Category = category,
            IsCompleted = isCompleted
        };

        taskManager.Tasks.Add(newTask);
        await taskManager.WriteTasksToCSV();
    }
}