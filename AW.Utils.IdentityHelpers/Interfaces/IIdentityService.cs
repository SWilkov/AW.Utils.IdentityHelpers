namespace AW.Utils.IdentityHelpers.Interfaces
{
  public interface IIdentityService
  {
    string GetUsername();
    bool IsAuthenticated();
  }
}