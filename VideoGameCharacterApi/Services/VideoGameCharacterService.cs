using Microsoft.EntityFrameworkCore;
using VideoGameCharacterApi.Data;
using VideoGameCharacterApi.DTOS;
using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services
{
    public class VideoGameCharacterService(AppDbContext context) : IVideoGameCharacteService
    {
 

        public Task<AddCharacterRequest> AddCharacter(AddCharacterRequest character)
        {
            var newCharacter = new Character
            {
                Name = character.Name,
                Game = character.Game,
                Role = character.Role
            };
            context.Characters.Add(newCharacter);
            context.SaveChanges();
            var result = new AddCharacterRequest(newCharacter.Name, newCharacter.Game, newCharacter.Role);
            return Task.FromResult(result);
        }

        public async Task<bool> DeleteCharacter(int id)
        {
            var affected =await context.Characters.Where(c=>c.Id==id).ExecuteDeleteAsync();
            await context.SaveChangesAsync();
            return affected > 0;
        }

        public async Task<GetCharacterRequest?> GetCharacterByIdAsync(int id)
        {
            Character? result = await context.Characters.FindAsync(id);
                if (result is null)
                    return null;
                var character = new GetCharacterRequest(result.Id,result.Name,result.Game,result.Role);

            return character;
        }

        public async Task<List<GetCharacterRequest>> GetCharactersAsync()
        {
            var result= await context.Characters.ToListAsync();

            var characters = result.Select(c => new GetCharacterRequest(c.Id,c.Name,c.Game,c.Role)).ToList();
            return characters;
        }

        public async Task<bool> UpdateCharacter(int id, UpdateCharacterRequest character)
        {
            var existingCharacter = await context.Characters.FindAsync(id);

            if (existingCharacter is null)
                return false;

            existingCharacter.Name = character.Name;
            existingCharacter.Game = character.Game;
            existingCharacter.Role = character.Role;
            await context.SaveChangesAsync();
            return true;
        }
    }
}
