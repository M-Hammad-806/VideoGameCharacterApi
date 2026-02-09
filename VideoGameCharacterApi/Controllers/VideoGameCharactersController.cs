using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterApi.DTOS;
using VideoGameCharacterApi.Models;
using VideoGameCharacterApi.Services;

namespace VideoGameCharacterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharactersController(IVideoGameCharacteService service) : ControllerBase
    {
      
    
    [HttpGet]
        public async Task<ActionResult<List<GetCharacterRequest>>> Get()
        => await Task.FromResult(await service.GetCharactersAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> Get(int id)
        {
            var c= await service.GetCharacterByIdAsync(id);
            if (c is null)
                return NotFound("The character with given id is not found.");
            return Ok(c);
        }
        [HttpPost]
        public async Task<ActionResult<AddCharacterRequest>> Post(AddCharacterRequest character)
        {
            var c = await service.AddCharacter(character);
            if (c is null)
                return BadRequest("Retry to Add the Character!");
            return Ok(c);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateCharacterRequest character)
        {
            var isUpdated = await service.UpdateCharacter(id, character);
            if (!isUpdated)
                return BadRequest("The character with given id is not found.");
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
                       var isDeleted = await service.DeleteCharacter(id);
            if (!isDeleted)
                return BadRequest("The character with given id is not found.");
            return NoContent();
        }
    }
}
