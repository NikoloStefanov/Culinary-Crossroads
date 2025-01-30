using System.Security.Claims;

namespace Culinary_Crossroads.Extensions
{
    public static class ClaimsPrincipalExtentions
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
