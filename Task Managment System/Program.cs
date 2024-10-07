using System;
using System.Collections.Generic;
using Task_Managment_System.Commands;
using Task_Managment_System.Notifications;
using Task_Managment_System.Sorting;
using Task_Managment_System.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Set up the task manager and user (observer)
        var taskManager = new TaskManager();
        var user = new User("John");
        taskManager.Subscribe(user);

        // Create tasks using the factory method
        var workTaskFactory = new WorkTaskFactory();
        var personalTaskFactory = new PersonalTaskFactory();

        Tasky workTask1 = workTaskFactory.CreateTask("Complete project report", DateTime.Now.AddDays(3));
        Tasky workTask2 = workTaskFactory.CreateTask("Prepare meeting agenda", DateTime.Now.AddDays(1));
        Tasky personalTask1 = personalTaskFactory.CreateTask("Buy groceries", DateTime.Now.AddDays(2));
        Tasky personalTask2 = personalTaskFactory.CreateTask("Gym session", DateTime.Now.AddDays(5));

        // Add tasks to the task manager and notify observers
        taskManager.CreateTask(workTask1);
        taskManager.CreateTask(workTask2);
        taskManager.CreateTask(personalTask1);
        taskManager.CreateTask(personalTask2);

        // Display the current task list
        Console.WriteLine("\n--- Task List Before Sorting ---");
        List<Tasky> tasks = new List<Tasky> { workTask1, workTask2, personalTask1, personalTask2 };
        foreach (var task in tasks)
        {
            task.Display();
        }

        // Test Sorting: by Deadline and by Title using Strategy Pattern
        var sorter = new TaskSorter();

        // Sort by Deadline
        sorter.SetSortStrategy(new SortByDeadLine());
        sorter.SortTasks(tasks);
        Console.WriteLine("\n--- Task List Sorted by Deadline ---");
        foreach (var task in tasks)
        {
            task.Display();
        }

        // Sort by Title
        sorter.SetSortStrategy(new SortByTitle());
        sorter.SortTasks(tasks);
        Console.WriteLine("\n--- Task List Sorted by Title ---");
        foreach (var task in tasks)
        {
            task.Display();
        }

        // Test Command Pattern: Marking tasks as completed and undoing actions
        var commandManager = new CommandManager();
        var completeTaskCommand1 = new CompleteTaskCommand(workTask1);
        var completeTaskCommand2 = new CompleteTaskCommand(personalTask1);

        // Mark tasks as completed
        Console.WriteLine("\n--- Completing Tasks ---");
        commandManager.ExecuteCommand(completeTaskCommand1);  // Complete the first work task
        commandManager.ExecuteCommand(completeTaskCommand2);  // Complete the first personal task

        // Undo task completion
        Console.WriteLine("\n--- Undoing Task Completion ---");
        commandManager.Undo();  // Undo the last action (undo personal task completion)
        commandManager.Undo();  // Undo the previous action (undo work task completion)

        // Test notification system by adding another task
        Console.WriteLine("\n--- Adding a New Task to Notify User ---");
        Tasky workTask3 = workTaskFactory.CreateTask("Finish presentation slides", DateTime.Now.AddDays(4));
        taskManager.CreateTask(workTask3);

        // Display final task list
        Console.WriteLine("\n--- Final Task List ---");
        tasks.Add(workTask3);
        foreach (var task in tasks)
        {
            task.Display();
        }
    }
}
