using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services
{
    public class VideoGameCharacterService : IVideoGameCharacteService
    {
        static List<Character> characters = new List<Character>
        {
            new Character { Id = 1, Name = "Mario", Game = "Super Mario Bros.", Role = "Protagonist" },
            new Character { Id = 2, Name = "Bowser", Game = "Super Mario Bros.", Role = "Villian" },
            new Character { Id = 3, Name = "Link", Game = "The Legend of Zelda", Role = "Protagonist" },
            new Character { Id = 4, Name = "Master Chief", Game = "Halo", Role = "Protagonist" },
            new Character {Id=5, Name = "Zelda", Game = "The Legend of Zelda", Role = "Princess" }
        };

        public Task<Character> AddCharacter(Character character)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCharacter(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Character?> GetCharacterByIdAsync(int id)
        {
            return Task.FromResult(characters.FirstOrDefault(c => c.Id == id));
        }

        public Task<List<Character>> GetCharactersAsync()
        {
            return Task.FromResult(characters);
        }

        public Task<bool> UpdateCharacter(int id, Character character)
        {
            throw new NotImplementedException();
        }
    }
}
