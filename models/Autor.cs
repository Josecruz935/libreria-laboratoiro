using System.ComponentModel.DataAnnotations;

public class Autor{
[Key]
 public Guid AutorId { get; set; } = Guid.NewGuid();
[Required]
public String Nombre{get; set;}
[Required]
public String Apellido{get;set;}
[Required]
public String Nacionalidad{get;set;}



}