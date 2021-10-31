using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book);
            }
        }
    }
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }
        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors { get; private set; }

        public int CompareTo(Book other)
        {
            if (this.Year != other.Year)
            {
                return this.Year.CompareTo(other.Year);
            }

            return this.Title.CompareTo(other.Title);
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
    public class Library : IEnumerable<Book>
    {
        public readonly SortedSet<Book> books;

        private class LibraryIterator : IEnumerator<Book>
        {
            private SortedSet<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                Reset();
                this.books = new SortedSet<Book>(books, new BookComparator());
            }
            public bool MoveNext()
            {
                return ++currentIndex < books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public Book Current => books.ToList()[currentIndex];

            object? IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books, new BookComparator());
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            if (x.Title != y.Title)
            {
                return x.Title.CompareTo(y.Title);
            }

            return y.Year.CompareTo(x.Year);
        }
    }
}
