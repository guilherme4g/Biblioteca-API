using Biblioteca_API.Models;
using System.Collections.Generic;

namespace Biblioteca_API.Contracts
{
   public interface IBookRepository
    {
        List<Book> Get();
        Book Get(int id);
        bool Create(Book book);
        bool Update(Book book);
        bool Delete(int id);
    }   
}
