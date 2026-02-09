namespace VideoGameCharacterApi.DTOS
{
    public record UpdateCharacterRequest(
        int Id,
        string Name,
        string Game,
        string Role
    );
}
