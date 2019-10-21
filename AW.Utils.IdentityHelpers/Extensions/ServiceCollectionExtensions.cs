using Microsoft.Extensions.DependencyInjection;

namespace AW.Utils.IdentityHelpers.Extensions
{
  public static class ServiceCollectionExtensions
  {
    public static void AddIdentityHelpers(this IServiceCollection services)
    {
      services.AddScoped<Interfaces.IIdentityService, Services.IdentityService>();
    }
  }
}
