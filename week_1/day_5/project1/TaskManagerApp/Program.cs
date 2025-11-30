using System;
using System.Collections.Generic;


namespace TaskManagerApp
{
    class Program
    {
        static List<TaskItem> tasks = new List<TaskItem>();

        static void AddTask()
        {
            Console.Clear();
            Console.WriteLine("Add a New Task");

            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            tasks.Add(new TaskItem
            {
                Title = title,
                Description = description,
                Status = "Pending"
            });

            Console.WriteLine("\nTask added! Press Enter to return.");
            Console.ReadLine();
        }

        static void ViewTasks()
        {
            Console.Clear();

            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
            }
            else
            {
                int index = 1;
                foreach (var task in tasks)
                {
                    Console.WriteLine($"Task #{index}");
                    Console.WriteLine(task);
                    Console.WriteLine("------------------------");
                    index++;
                }
            }

            Console.WriteLine("\nPress Enter to return.");
            Console.ReadLine();
        }

        static void UpdateTaskStatus()
        {
            Console.Clear();
            ViewTasks();

            if (tasks.Count == 0)
                return;

            Console.Write("Enter task number to update: ");

            if (int.TryParse(Console.ReadLine(), out int number) &&
                number >= 1 && number <= tasks.Count)
            {
                var task = tasks[number - 1];
                task.Status = task.Status == "Pending" ? "Completed" : "Pending";

                Console.WriteLine("Task status updated!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }

            Console.WriteLine("\nPress Enter to return.");
            Console.ReadLine();
        }

        static void DeleteTask()
        {
            Console.Clear();
            ViewTasks();

            if (tasks.Count == 0)
                return;

            Console.Write("Enter task number to delete: ");

            if (int.TryParse(Console.ReadLine(), out int number) &&
                number >= 1 && number <= tasks.Count)
            {
                Console.Write("Are you sure? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    tasks.RemoveAt(number - 1);
                    Console.WriteLine("Task deleted.");
                }
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }

            Console.WriteLine("\nPress Enter to return.");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Your Task Manager!");
                Console.WriteLine("1. Add a Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Update Task Status");
                Console.WriteLine("4. Delete a Task");
                Console.WriteLine("5. Exit");
                Console.Write("\nChoose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        UpdateTaskStatus();
                        break;
                    case "4":
                        DeleteTask();
                        break;
                    case "5":
                        running = false;
                        break;
                }
            }
        }
    }
}
