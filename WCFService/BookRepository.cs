using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();
        private int counter = 1;

        public BookRepository()
        {
            AddNewBook(new Book { Title = "Thinking in C#", ISBN = "65674523432423" });
            AddNewBook(new Book { Title = "Thinking in Java", ISBN = "34223434543423" });
            AddNewBook(new Book { Title = "Beginning WCF", ISBN = "35343532423" });
        }

        //CRUD Operations
        //1. CREAT
        public Book AddNewBook(Book newBook)
        {
            if (newBook == null)
                throw new ArgumentNullException("newBook"); newBook.BookId = counter++;
            books.Add(newBook);
            return newBook;
        }

        //2. RETRIEVE /ALL
        public List<Book> GetAllBooks()
        {
            return books;
        }

        //2. RETRIEVE /By BookId
        public Book GetBookById(int bookId)
        {
            return books.Find(b => b.BookId == bookId);
        }

        //3. UPDATE
        public bool UpdateABook(Book updatedBook)
        {
            if (updatedBook == null)
                throw new ArgumentNullException("updatedBook");
            int idx = books.FindIndex(b => b.BookId == updatedBook.BookId);
            if (idx == -1)
                return false;
            books.RemoveAt(idx);
            books.Add(updatedBook);
            return true;
        }

        //4. DELETE
        public bool DeleteABook(int bookId)
        {
            int idx = books.FindIndex(b => b.BookId == bookId);
            if (idx == -1)
                return false;

            books.RemoveAll(b => b.BookId == bookId);
            return true;
        }
    }
}