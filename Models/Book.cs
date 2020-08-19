using System;

namespace Biblioteca_API.Models{
  public class Book {
    
    public string title {get; set;}
    public string author {get; set;}

    public Book(string title, string author){
      this.title = title;
      this.author = author;
    }

  }
}