using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PE_Properties
{
    internal class Book
    {

        // *** FIELDS ***
        private string title;
        private string author;
        private int numberOfPages;
        private string owner;
        private int totalTimesRead = 0;

        /// <summary>
        /// Book Information
        /// </summary>
        /// <param name="title">title of book</param>
        /// <param name="author">author of book</param>
        /// <param name="numberOfPages">page length of book</param>
        /// <param name="owner">current owner of book</param>
        public Book(string title, string author, int numberOfPages, string owner)
        {
            this.title = title;
            this.author = author;
            this.numberOfPages = numberOfPages;
            this.owner = owner;
        }

        /// <summary>
        /// Read-Only Property of Title Feild 
        /// </summary>
        public string Title
        {
            get 
            {
                return title; 
            }
        }

        /// <summary>
        /// Read-Only Property of Author Feild 
        /// </summary>
        public string Author
        {
            get 
            { 
                return author;
            }
        }

        /// <summary>
        /// Read-Only Property of NumberOfPages Feild 
        /// </summary>
        public int NumberOfPages
        {
            get
            {
                return numberOfPages;
            }
        }

        /// <summary>
        /// Get & Set Block of Owner Feild
        /// </summary>
        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                if (value.Length != 0)
                {
                    owner = value;
                }
            }
        }

        /// <summary>
        /// Get & Set Block of TotalTimesRead Feild
        /// </summary>
        public int TotalTimesRead
        {
            get
            {
                return totalTimesRead;
            }
            set
            {
                if (value > totalTimesRead)
                {
                    totalTimesRead = value;
                }
            }
        }

        /// <summary>
        /// Read-Only Property of IsUsed
        /// </summary>
        public bool IsUsed
        {
            get
            {
                if (totalTimesRead > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Prints Out All Book Information
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Pages: {numberOfPages}");
            Console.WriteLine($"Owner: {owner}");
            Console.WriteLine($"Times Read: {totalTimesRead}");
            Console.WriteLine($"Is Used: {IsUsed}");
        }
    }
}
