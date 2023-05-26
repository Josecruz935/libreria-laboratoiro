
using libreria.Service;
using Microsoft.AspNetCore.Mvc;
namespace libreria.MapControllers;

//atributos para los controles
[ApiController]
[Route("[controller]")]

public class AutorController: ControllerBase
{

        IAutorService autorService;
    public AutorController(IAutorService serviceAutor) => autorService = serviceAutor;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostAutors([FromBody] Autor newAutor) {
    await autorService.insertar(newAutor);
    var result = newAutor.AutorId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult GetAutores() {

return Ok(autorService.obtener());
}

//Update
[HttpPut("{id}")]
public IActionResult UpdateAutores([FromBody] Autor autorActualizar, Guid id) {
    autorService.Actualizar(id,autorActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteAutores(Guid id) {
return Ok(autorService.eliminar(id));



}




}