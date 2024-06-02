namespace Classes_Assignment_CSI120
{
    internal class Program
    {
        //Kady Tran
        //6/01/2024
        //Classes Assignment

        static void Main(string[] args)
        {
            // Placing this in the Main method of the Program class
            // To create an array to store up to 10 Book objects
            Book[] books = new Book[10];
            int bookCount = 0;

            // Creating a bool for the while loop
            bool running = true;

            while (running) // Using while loop to ensure the program continues running until the player decides to exit
            {
                // Display the menu and handle the user's choice
                // ref keyword
                // you place the ref keyword in front of a parameter to indicate you are passing by reference
                Menu(books, ref bookCount, ref running); // 
            } // End of while loop

        } // End of main


        // Creating a class named Book
        public class Book
        {
            // Creating 3 fields: title, author, and year
            public string Title;
            public string Author;
            public int Year;

            // Constructor
            // Create a new Constructor
            // public ClassName (parameters) { Code }
            public Book(string title, string author, int year)
            {
                // Field - parameter
                Title = title;
                Author = author;
                Year = year;
            } // End of constructor

            // Method to display book information
            public void DisplayBookInfo()
            {
                // Concatenating it so the string and data ties together
                Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}");
            }

        } // End of Book Class

        // Method to add a book to the array - this is getting and setting the data
        public static void EnterValueIntoArray(Book[] books, int bookCount, string title, string author, int year)
        {
            books[bookCount] = new Book(title, author, year);

        } // End of EnterValueIntoArray

        public static void Menu(Book[] books, ref int bookCount, ref bool running)
        {
            // Display the menu
            Console.WriteLine("Book Manager");
            Console.WriteLine("1. Add a new book");
            Console.WriteLine("2. Display all books");
            Console.WriteLine("3. Update a book's information");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            // Asking for user input
            string choice = Console.ReadLine();

            // Using switch to redirect the user to their choice
            switch (choice)
            {
                case "1":
                    // Add a new book
                    if (bookCount < 10)
                    {
                        // Asking for Title
                        Console.Write("Enter the title: ");
                        string title = Console.ReadLine();

                        // Asking for the Author
                        Console.Write("Enter the author: ");
                        string author = Console.ReadLine();

                        // Asking for the year
                        Console.Write("Enter the year of publication: ");
                        int year = int.Parse(Console.ReadLine());

                        // This adds the new book and its data into the array
                        books[bookCount] = new Book(title, author, year);
                        bookCount++; // incremented by 1
                        Console.WriteLine("Book added successfully!\n"); // Displays message of it being successfully added
                    }
                    else
                    {
                        // If there is no room, this message will show that the array is full
                        Console.WriteLine("No more books can be added. The array is full.\n");
                    }
                    break;

                case "2":
                    // Display all books
                    Console.WriteLine("Displaying all books:");
                    for (int i = 0; i < bookCount; i++)
                    {
                        // Calling our DisplayBookInfo method
                         books[i].DisplayBookInfo(); 
                    }
                    Console.WriteLine();
                    break;

                case "3":
                    // Update a book's information
                    Console.Write("Enter the title of the book to update: "); // Asking for user input
                    string searchTitle = Console.ReadLine(); // Reading user input
                    bool found = false;

                    for (int i = 0; i < bookCount; i++)
                    {
                        if (books[i].Title == searchTitle)
                        {
                            // Title
                            Console.Write("Enter the new title: ");
                            books[i].Title = Console.ReadLine();

                            //Author
                            Console.Write("Enter the new author: ");
                            books[i].Author = Console.ReadLine();

                            // Year
                            Console.Write("Enter the new year of publication: ");
                            books[i].Year = int.Parse(Console.ReadLine());

                            // Displays success message
                            Console.WriteLine("Book information updated successfully!\n");
                            found = true;
                            break;
                        }
                    }

                    if (!found) 
                    {
                        Console.WriteLine("Book not found.\n");
                    }
                    break;

                case "4":
                    // Exit the program
                    Console.WriteLine("You have exited");
                    running = false; // setting the running into a false will exit the program 
                    break;

                default:
                    // Invalid choice
                    Console.WriteLine("You've entered an invalid choice. Please try again.\n");
                    break;
            }
            
        }

    } // End of Class
} // End of Namespace

/* Objective:
Create a simple console application that manages a collection of Book objects.
This assignment will help you practice defining classes, creating objects, and manipulating data within a class.
____

Fields: Variables that belong to a class. They hold the data for the object.
Constructor: A special method that initializes an object. It sets the initial values for the fields.
Initialization: The process of assigning values to the fields of an object when it is created.
 */
