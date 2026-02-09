namespace VideoGameCharacterApi.DTOS
{
    public record GetCharacterRequest(
        int Id,
        string Name,
        string Game,
        string Role
    );
}
