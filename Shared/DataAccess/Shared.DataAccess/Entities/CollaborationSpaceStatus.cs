namespace Mvc6Recipes.Shared.DataAccess
{
    public enum ProjectStatus : byte
    {
        Active,
        Filled,
        Mix,
        Review,
        Published,
        OnHold,
        Canceled
    }

    public enum ProjectCopyrightModel : byte
    {
        Shared,
        SoleOwnership,
        Community,
        NotSet
    }
}