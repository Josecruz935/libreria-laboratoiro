using libreria;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{


libreriaContext Dbcontext;


public HomeController(libreriaContext db){
Dbcontext = db;

}

[HttpGet]
[Route("ConnDB")]
public IActionResult ConnDB(){
Dbcontext.Database.EnsureCreated();
return Ok();

}
}