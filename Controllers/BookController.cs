using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using Biblioteca_API.Models; 
using Biblioteca_API.Repositories;
using System.Dynamic;

namespace Biblioteca_API.Controllers
{
    [ApiController]
    [Route("/api/livros")]
    public class UserController : ControllerBase
    {

      BookRepository bookRepository = new BookRepository();
      
        [HttpGet]
        public string get() {
          List<Book> books = bookRepository.Get();
          return JsonSerializer.Serialize(books);
        }

        [HttpGet("{id}")]
        public string get(int id) {
          Book book = bookRepository.Get(id);
          return JsonSerializer.Serialize(book);
        }
        
        [HttpPost]
        public string post([FromBody]Book book) {
          dynamic response = new ExpandoObject();
          bool inserted = bookRepository.Create(book);
          if (inserted) {
            response.sucess = "Livro inserido com sucesso";
          } else {
            response.sucess = "Erro ao inserir editar o Livro";
          }   
          return JsonSerializer.Serialize(response);
        }

        [HttpPut("{id}")]
        public string Update(int id, [FromBody]Book book) {
          dynamic response = new ExpandoObject();
          bool edited = bookRepository.Update(id, book);
          if (edited) {
            response.sucess = "Livro editado com sucesso";
          } else {
            response.sucess = "Erro ao tentar editar o Livro";
          }   
          return JsonSerializer.Serialize(response);
        }

        [HttpDelete("{id}")]
        public string delete(int id) {
          dynamic response = new ExpandoObject();
          bool deleted = bookRepository.Delete(id);
          if (deleted) {
            response.sucess = "Livro deletado com sucesso";
          } else {
            response.sucess = "Erro ao tentar deletar o Livro";
          }   
          return JsonSerializer.Serialize(response);
        }
    }
}
