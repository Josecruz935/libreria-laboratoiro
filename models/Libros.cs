

using System.ComponentModel.DataAnnotations;

public class Libros{
[Key]
public Guid LibrosId{get; set;}= Guid.NewGuid();

[Required]
[MaxLength(100)]
public String  Nombre{get; set;}

[Required]
public int Edicion{get; set;}

[Required]
public int Paginas{get;set;}


}