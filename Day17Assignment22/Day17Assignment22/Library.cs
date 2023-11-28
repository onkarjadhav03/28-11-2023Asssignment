using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17Assignment22
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully!");
        }

        public void ViewAllBooks()
        {
            Console.WriteLine("All Books in the Library:");

            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
        }

        public void SearchBookById(int bookId)
        {
            Book foundBook = books.Find(book => book.BookId == bookId);

            if (foundBook != null)
            {
                DisplayBookDetails(foundBook);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }


        public void SearchBookByTitle(string title)
        {
            Book foundBook = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (foundBook != null)
            {
                DisplayBookDetails(foundBook);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        private void DisplayBookDetails(Book book)
        {
            Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
        }
    }
}
