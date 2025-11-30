﻿using System;

namespace TaskManagerApp
{
    class Program
    {
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
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        running = false;
                        break;
                }
            }
        }
    }
}
