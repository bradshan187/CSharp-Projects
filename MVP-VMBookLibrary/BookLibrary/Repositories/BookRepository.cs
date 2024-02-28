
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLibrary.Repositories {
    public class BookRepository {
        private readonly List<Book> _books;
        private static readonly object Lock = new object();
        private static volatile BookRepository _instance;

        public BookRepository() { 
            _books = new List<Book>();
            InitBooks();
        }

        public static BookRepository Instance {
            get {
                if (_instance == null) {
                    lock (Lock) {
                        if (_instance == null) {
                            _instance = new BookRepository();
                        }
                    }
                }

                return _instance;
            }
        }

        private void InitBooks() {
            _books.Add(new Book { Author = "J.K Rowling", Genre = "Fantasy", Name = "Harry Potter and the Philosopher's Stone", Pages = 352 });
            _books.Add(new Book { Author = "Mario Puzo", Genre = "Crime", Name = "The Godfather", Pages = 365 });
            _books.Add(new Book { Author = "Quentin Tarentino", Genre = "Drama", Name = "Once Upon a Time in Hollywood", Pages = 895 });
        }

        public List<Book> GetAllBooks() {
            return _books;
        }

        public List<Book> GetAllBooks(string filter) {
            return _books.Where(x => x.Author.Contains(filter) || x.Genre.Contains(filter) || x.Name.Contains(filter) || x.Pages.ToString().Contains(filter)).ToList();
        }

        public void InsertBook(Book book) {
            // Business operations
            _books.Add(book);
        }

        public void UpdateBook(Book book) {
            // Business operations
        }

        public void DeleteBook(Book book) {
            _books.Remove(book);
        }
    }
}