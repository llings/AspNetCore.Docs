using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace RoutingSample
{
    public class StartupRequireHost
    {
        #region snippet
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", context => context.Response.WriteAsync("Hi Contoso!"))
                    .RequireHost("contoso.com");
                endpoints.MapGet("/", context => context.Response.WriteAsync("Hi AdventureWorks!"))
                    .RequireHost("adventure-works.com");
                endpoints.MapHealthChecks("/healthz").RequireHost("*:8080");
            });
        }
        #endregion
    }
}