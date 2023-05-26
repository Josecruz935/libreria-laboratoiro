using libreria.Service;
using Microsoft.AspNetCore.Mvc;
namespace libreria.MapControllers;

//atributos para los controles
[ApiController]
[Route("[controller]")]

public class LibrosController : ControllerBase
{
    //Atributos para la clase
    ILibroService libroService;
    public LibrosController(ILibroService serviceLibro) => libroService = serviceLibro;

    [HttpPost]
    public async Task<IActionResult> PostLibros([FromBody] Libros newLibro)
    {
        await libroService.insertar(newLibro);
        var res = newLibro.LibrosId;
        if (res == null)
        {
            return BadRequest();
        }

        return Ok("Se ingreso Correctamente");
    }

    [HttpGet]
    public IActionResult GetLibros()
    {

        return Ok(libroService.obtener());
    }


    [HttpPut("{id}")]
    public IActionResult UpdateLibros(Libros librosActualizar, Guid id)
    {
        libroService.Actualizar(id, librosActualizar);
        return Ok();
    }


    [HttpDelete("{id}")]
    public IActionResult DeleteLibros(Guid id)
    {
        libroService.eliminar(id);
        return Ok("Se Elimino Correctamente");
    }

}
