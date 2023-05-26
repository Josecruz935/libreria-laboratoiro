namespace libreria.Service;



public class LibroService : ILibroService
{
    //Inyeccion de dependencias.
    libreriaContext context2;

    public LibroService(libreriaContext DbContext) => context2 = DbContext;

    //CRUD

    //Create

    //Async await

    public async Task insertar(Libros inputLibros)
    {
        await context2.AddAsync(inputLibros);
        await context2.SaveChangesAsync();
    }


    //READ - obtener de la db 
    public IEnumerable<Libros> obtener() => context2.Libros;

    //UPDATE
    public async Task Actualizar(Guid id, Libros inputLibros)
    {
        try
        {
            var Libros = context2.Libros.Find(id);
            if (Libros != null)
            {
                Libros.Nombre = inputLibros.Nombre;
                Libros.Edicion = inputLibros.Edicion;
                Libros.Paginas = inputLibros.Paginas;

                await context2.SaveChangesAsync();
            }


        }
        catch (Exception x)
        {
            Console.WriteLine("Error al actualizar" + x.Message);
        }

    }




    public async Task eliminar(Guid id)
    {
        var Libros = context2.Libros.Find(id);
        if (Libros != null)
        {
            context2.Remove(Libros);
            await context2.SaveChangesAsync();
        }
    }

    public async Task<bool> ExisteAutor(Guid LibrosId)
    {
        var Libros = await context2.Libros.FindAsync(LibrosId);
        return Libros != null;
    }
}


public interface ILibroService
{
    Task insertar(Libros inputlibros);
    IEnumerable<Libros> obtener();
    Task Actualizar(Guid id, Libros libros);
    Task eliminar(Guid Id);

}