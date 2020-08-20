using System;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca_API.Models{
  public class Book {
    
    public int id {get; set;}

    [Required(ErrorMessage="O título é obrigatório", AllowEmptyStrings = false)]
    public string title {get; set;}

    [Required(ErrorMessage="O nome do autor é obrigatório", AllowEmptyStrings = false)]
    public string author {get; set;}

    [Required(ErrorMessage="O isbn é obrigatório", AllowEmptyStrings = false)]
     [StringLength(13)]
    public string isbn {get; set;}
    public string description {get; set;}

    public Book(int id, string description, string title, string author, string isbn){
      this.id = id;
      this.title = title;
      this.author = author;
      this.isbn = isbn;
      this.description = description;
    }

  }
}