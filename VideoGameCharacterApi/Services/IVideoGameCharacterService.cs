using VideoGameCharacterApi.DTOS;
using VideoGameCharacterApi.Models;
namespace VideoGameCharacterApi.Services
{
    public interface IVideoGameCharacteService
    {
        public Task<List<GetCharacterRequest>> GetCharactersAsync();
        public Task<GetCharacterRequest> GetCharacterByIdAsync(int id);
        public Task<AddCharacterRequest?> AddCharacter(AddCharacterRequest character);
        public Task<bool> UpdateCharacter(int id, UpdateCharacterRequest character);
        public Task<bool> DeleteCharacter(int id);

    }
}
