

namespace DevFramework.Core.Infrastructure.Constants
{
    public static class Constant
    {
        public const int DefaultCity = 1;
        public const int DefaultPageSize = 8;
        public const int DefaultPageIndex = 0;

        public static class JwtClaimIdentifiers
        {
            public const string Rol = "rol", Id = "id";
        }

        public static class JwtClaims
        {
            public const string ApiAccess = "api_access";
        }
    }
}