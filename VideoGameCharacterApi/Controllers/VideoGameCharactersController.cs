using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterApi.Models;
using VideoGameCharacterApi.Services;

namespace VideoGameCharacterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharactersController(IVideoGameCharacteService service) : ControllerBase
    {
      
    
    [HttpGet]
        public async Task<ActionResult<List<Character>>> Get()
        => await Task.FromResult(await service.GetCharactersAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> Get(int id)
        {
            var c= await service.GetCharacterByIdAsync(id);
            if (c is null)
                return NotFound("The character with given id is not found.");
            return Ok(c);
        }
    }
}
