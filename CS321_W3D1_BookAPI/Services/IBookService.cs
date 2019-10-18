using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApi.Models;

namespace BookApi.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book Get(int id);
        Book Add(Book book);
        Book Update(Book book);
        void Remove(Book book); // (variable type)
    }
}