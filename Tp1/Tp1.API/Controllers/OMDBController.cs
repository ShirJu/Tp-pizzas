using Microsoft.AspNetCore.Mvc;

namespace OMDB.API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class OMDBController : ControllerBase
{
    [HttpGet("movie/{imbdId}")]
    public async Task<IActionResult> GetByImdbId(string imbdId) {
        string respuesta = await HTTPhelper.GetContentAsync   ("http://www.omdbapi.com/?apikey=2796f0ce&i=" + imbdId, null);
        //http://www.omdbapi.com/?apikey=2796f0ce&i=tt3896198
         return Ok(respuesta);
    }
    [HttpGet("search")]
    public async Task<IActionResult> GetByTerm([FromQuery]string term) {
        string respuesta = await HTTPhelper.GetTaskAsync  ("http://www.omdbapi.com/?apikey=2796f0ce&t=" + term, null);
        //http://www.omdbapi.com/?apikey=2796f0ce&t=cars
        return Ok(respuesta);
    }

   
}
 