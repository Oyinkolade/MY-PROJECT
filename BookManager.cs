using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager
{
    class BookManager
    {
        List<string> listOfBooks { get; set; }
        int OperationChoice { get; set; }
        bool Running { get; set; }

        public BookManager()
        {
            listOfBooks = new List<string>();
        }

        public BookManager Run()
        {
            this.Running = true;
            while (Running)
            {
                Book book = new Book();
                Console.WriteLine("What do you want to do? [Type either 1, 2, 3, 4]");
                Console.WriteLine("1. Add a book" +
                                  "\n2. Remove a book" +
                                  "\n3. Search for a book" +
                                  "\n4. Exit");
                this.OperationChoice = Convert.ToInt16(Console.ReadLine());

                if (this.OperationChoice == 1)
                {
                    Console.WriteLine("Type the name of the book you want to add");
                    book.Title = Console.ReadLine();
                    this.listOfBooks.Add(book.Title);
                    Console.WriteLine("Book added successfully");
                }
                if (this.OperationChoice == 2)
                {
                    Console.WriteLine("Type the name of the book you want to remove");
                    book.Title = Console.ReadLine();
                    if (this.listOfBooks.Contains(book.Title))
                    {
                        this.listOfBooks.Remove(book.Title);
                        Console.WriteLine("Book removed successfully");
                    }
                    else
                    {
                        Console.WriteLine("The book you want to remove does not exist");
                    }
                }

                if (this.OperationChoice == 3)
                {
                    book.Title = Console.ReadLine();
                   if (this.listOfBooks.Contains(book.Title))
                    {
                        Console.WriteLine(book.Title);
                    }
                   else
                    {
                        Console.WriteLine("Book not found");
                    }
                }
                if (this.OperationChoice == 4)
                {
                    this.Running = false;
                    Console.WriteLine("Goodbye");
                }
            }
            return this;   
        }
    }
}
