using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    public class TaskManager
    {
        public List<Task> ListOfTasks { get; set; }
        public bool Running { get; set; }
        public int OperationChoice { get; set; }

        public TaskManager()
        {
            ListOfTasks = new List<Task>();
        }

        public TaskManager Run()
        {
            while (this.Running == true)
            {
                Task Task = new Task();

                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Show Tasks");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice: ");

                this.OperationChoice = Convert.ToInt32(Console.ReadLine());

                if (this.OperationChoice == 1)
                {
                    Console.WriteLine("Enter task title: ");
                    Task.Title = Console.ReadLine();
                    this.ListOfTasks.Add(Task);
                    Console.WriteLine("Task added successfully.");
                }

                else if (this.OperationChoice == 2)
                {
                    if (this.ListOfTasks.Count == 0)
                    {
                        Console.WriteLine("No tasks available.");
                    }
                    else
                    {
                        for (int i = 0; i < this.ListOfTasks.Count; i++)
                        {
                            Console.WriteLine(Task.Title);
                        }
                    }
                }

                else if (this.OperationChoice == 3)
                {
                    this.Running = false;
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            return this;
        }
    }
}
