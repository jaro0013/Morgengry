using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book GetBook(string itemId)
        {
            return books.Find(x => x.ItemId == itemId);
        }

        public double GetTotalValue()
        {
            double allBooks = 0;
            foreach (Book b in books)
            {
                allBooks += b.Price;
            }
            
            return allBooks;
        }
    }
}

