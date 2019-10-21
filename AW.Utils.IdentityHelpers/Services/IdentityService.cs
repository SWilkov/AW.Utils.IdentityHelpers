using AW.Utils.IdentityHelpers.Exceptions;
using AW.Utils.IdentityHelpers.Interfaces;
using System.Security.Claims;

namespace AW.Utils.IdentityHelpers.Services
{
  public class IdentityService : IIdentityService
  {
    public bool IsAuthenticated()
    {
      if (ClaimsPrincipal.Current?.Identity == null) return false;

      return ClaimsPrincipal.Current.Identity.IsAuthenticated;
    }

    public string GetUsername()
    {
      if (ClaimsPrincipal.Current?.Identity == null)
        return "";

      return ClaimsPrincipal.Current.Identity.IsAuthenticated ?
        ClaimsPrincipal.Current.Identity.Name
        : throw new UnAuthenticatedUserException($"User: {ClaimsPrincipal.Current.Identity.Name} is not authenticated");
    }
  }
}
