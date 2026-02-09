namespace VideoGameCharacterApi.DTOS
{
    public record AddCharacterRequest(
        string Name,
        string Game,
        string Role
    );
}
