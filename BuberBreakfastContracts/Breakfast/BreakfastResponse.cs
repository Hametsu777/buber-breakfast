namespace BuberBreakfastContracts.Breakfast
{
    public record BreakfastResponse(
        Guid Id,
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        DateTime LastModifiedDate,
        List<string> Savory,
        List<string> Sweet
        );
}
