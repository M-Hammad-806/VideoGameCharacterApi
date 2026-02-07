using VideoGameCharacterApi.Models;
namespace VideoGameCharacterApi.Services
{
    public interface IVideoGameCharacteService
    {
        public Task<List<Character>> GetCharactersAsync();
        public Task<Character> GetCharacterByIdAsync(int id);
        public Task<Character?> AddCharacter(Character character);
        public Task<bool> UpdateCharacter(int id, Character character);
        public Task<bool> DeleteCharacter(int id);

    }
}
