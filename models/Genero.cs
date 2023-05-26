
using System.ComponentModel.DataAnnotations;

public class Genero{

[Key]
public Guid GeneroId{get;set;} = Guid.NewGuid();

[Required]
public String Nombre{get;set;}

}