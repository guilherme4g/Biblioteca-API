using System;
using System.Collections.Generic;
using Biblioteca_API.Models;
using Biblioteca_API.Contracts;
using Biblioteca_API.Databases;
using Dapper;
using Npgsql;

namespace Biblioteca_API.Repositories
{
   public class BookRepository : IBookRepository
    {
        private NpgsqlConnection connection = PostgreSQLDatabase.getConnection();
        
        public List<Book> Get() {
          List<Book> books = connection.Query<Book>("SELECT * FROM books;").AsList();
          return books;
        }
        public Book Get(int id) {
          try
          {
              Book book = connection.Query<Book>($"SELECT * FROM books WHERE id = { id };").AsList()[0];
              return book;
          }
          catch (Exception e)
          {
              Console.WriteLine(e);
              return null;
          }
        }
        public bool Create(Book book) {
          int rowsAffected = 0;
          try
          {
              rowsAffected = connection.Execute($"INSERT INTO books (title, isbn, description, author) values ('{ book.title }','{ book.isbn }','{ book.description }','{ book.author }');");
          }
          catch (Exception e)
          {
              Console.WriteLine(e);
          }
          
          return (rowsAffected == 1)? true : false; 
        }
        public bool Update(int id, Book book) {
          int rowsAffected = 0;
          try
          {
              rowsAffected = connection.Execute($"UPDATE books SET title = '{ book.title }', isbn = '{ book.isbn }', description = '{ book.description }', author = '{ book.author }' WHERE id = { id };");
          }
          catch (Exception e)
          {
              Console.WriteLine(e);
          }
          
          return (rowsAffected == 1)? true : false; 
        }
        public bool Delete(int id) {
          int rowsAffected = 0;
          try
          {
              rowsAffected = connection.Execute($"DELETE FROM books WHERE id = { id };");
          }
          catch (Exception e)
          {
              Console.WriteLine(e);
          }
          
          return (rowsAffected == 1)? true : false; 
        }
    }   
}
