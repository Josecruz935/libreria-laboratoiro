
using Microsoft.EntityFrameworkCore;


namespace libreria{
public class libreriaContext: DbContext {

public DbSet<Autor> Autor {get;set;}
public DbSet<Genero> Genero {get; set;}
public DbSet<Libros> Libros {get; set;}
public libreriaContext(DbContextOptions<libreriaContext> options) : base(options){}
}}