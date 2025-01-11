// Tyler Bye
// 11/08/2024
// Learning Properties
namespace PE_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** VARIABLES ***
            string title;
            string author;
            int numberOfPages = 0;
            string owner;
            int result = -1;
            bool success = false;
            string userInput;

            // *** MAIN CODE ***
            // intro user to simulation
            Console.WriteLine("Welcome to Book Simulator 2024!\n");

            // ask user for title
            Console.Write("Enter the title of your book: ");
            title = Console.ReadLine()!.Trim();


            // ask user for author
            Console.Write($"Enter the author of {title}: ");
            author = Console.ReadLine()!.Trim();

            // ask user for page length
            do
            {
                Console.Write($"Enter the number of pages in {title}: ");
                success = int.TryParse(Console.ReadLine()!.Trim(), out result);

                // if parse fails, user input is invalid 
                if (success == false)
                {
                    Console.WriteLine("[Invalid]");
                }
            } while (!success);
            numberOfPages = result;

            // ask user for owner
            Console.Write($"Who currently owns {title}? ");
            owner = Console.ReadLine()!.Trim();

            // create object using user's information
            Book myBook = new Book(title, author, numberOfPages, owner);

            // tell user their options for commands
            Console.WriteLine("\nYou may now type any of the following commands:" +
                "\n[title, author, pages, owner, read, used, print, quit]");

            // ask user which option they want to preform 
            do
            {
                Console.Write("\nWhat would you like to do? ");
                userInput = Console.ReadLine()!.Trim().ToLower();

                switch (userInput)
                {
                    // tells user the title
                    case "title":
                        Console.WriteLine($"The book’s title is {myBook.Title}.");
                        break;
                    // tells user the author
                    case "author":
                        Console.WriteLine($"The book’s author is {myBook.Author}.");
                        break;
                    // tells user the page length
                    case "pages":
                        Console.WriteLine($"The book has {myBook.NumberOfPages} pages.");
                        break;
                    // asks user if they want to change owner
                    case "owner":
                        Console.Write($"Do you want to change the owner? ");
                        userInput = Console.ReadLine()!.Trim();

                        // ask user for new owner name & change owner
                        if (userInput == "yes")
                        {
                            Console.Write($"Who is the new owner? ");
                            owner = Console.ReadLine()!.Trim();
                            Console.WriteLine($"The book’s owner is now {owner}.");
                        }
                        // tells user current owner
                        else
                        {
                            Console.WriteLine($"The book’s owner is {owner}.");
                        }
                        break;
                    // adds to the total times read & tells user the total time read AFTER
                    case "read":
                        myBook.TotalTimesRead++;
                        Console.WriteLine($"You have read the book, bringing the total " +
                            $"up to {myBook.TotalTimesRead} time(s).");
                        break;
                    // tells user if the book has been used before
                    case "used":
                        if (myBook.IsUsed)
                        {
                            Console.WriteLine("Yes, the book is used.");
                        }
                        else
                        {
                            Console.WriteLine("No, the book is not used.");
                        }
                        break;
                    // prints out all of the book's information
                    case "print":
                        myBook.Print();
                        break;
                    // ends the command section
                    case "quit":
                        break;
                    // tells user if input is invalid 
                    default:
                        Console.WriteLine("[Invalid]");
                        break;
                }
            } while (userInput != "quit");

            // thanks user before ending
            Console.WriteLine("Thank you for trying Book Simulator 2024!");
        }
    }
}
