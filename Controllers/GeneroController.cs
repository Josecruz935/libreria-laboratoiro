using libreria.Service;
using Microsoft.AspNetCore.Mvc;
namespace libreria.MapControllers;

//atributos para los controles
[ApiController]
[Route("[controller]")]

public class GeneroController : ControllerBase
{
    //Atributos para la clase
    IGeneroService generoService;
    public GeneroController(IGeneroService serviceGenero) => generoService = serviceGenero;

    [HttpPost]
    public async Task<IActionResult> PostGenero(Genero newGenero)
    {
        await generoService.insertar(newGenero);
        var result = newGenero.GeneroId;
        if (result == null)
        {

            return BadRequest();
        }
        return Ok("Se ingreso Correctamente");
    }

    [HttpGet]
    public IActionResult GetGenero()
    {

        return Ok(generoService.obtener());
    }

    //Update
    [HttpPut("{id}")]
    public IActionResult UpdateGenero(Genero generoActualizar, Guid id)
    {

        generoService.Actualizar(id, generoActualizar);

        return Ok("Se Actualizo Correctamente");
    }


    [HttpDelete("{id}")]
    public IActionResult DeleteGenero(Guid id)
    {
        generoService.eliminar(id);
        return Ok("Se elimino Correctamente");
    }

}
