using ErrorOr;

namespace BuberBreakfast.ServiceErrors
{
    public static class ErrorsBreakfast
    {
        public static class Breakfast
        {
            // Using a nuget package for the error package. Nuget package is ErrorOr.
            public static Error NotFound = Error.NotFound(
                code: "Breakfast.NotFound",
                description: "Breakfast not found"
                );
        }
    }
}
