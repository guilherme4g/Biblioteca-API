using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Biblioteca_API.Models; 

namespace Biblioteca_API.Controllers
{
    [ApiController]
    [Route("/api/livros")]
    public class UserController : ControllerBase
    {
      
        [HttpGet]
        public string get() {
          object obj = new {  };
          return JsonSerializer.Serialize(obj);
        }

        [HttpGet("{id}")]
        public string get(string id) {
          object obj = new {  };
          return JsonSerializer.Serialize(obj);
        }
        
        [HttpPost]
        public string post([FromBody]Book book) {
          return JsonSerializer.Serialize(book);
        }

        [HttpPut("{id}")]
        public string post(string id, [FromBody]Book book) {
          return JsonSerializer.Serialize(book);
        }

        [HttpDelete("{id}")]
        public string delete(string id) {
          object obj = new {  };
          return JsonSerializer.Serialize(obj);
        }
    }
}
