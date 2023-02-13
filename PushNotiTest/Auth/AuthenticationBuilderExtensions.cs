using Microsoft.AspNetCore.Authentication;
using PushDemoAPI.Authentication;

namespace PushNotiTest.Auth
{
    public static class AuthenticationBuilderExtensions
    {
        public static AuthenticationBuilder AddApiKeyAuth(
            this AuthenticationBuilder builder,
            Action<ApiKeyAuthOptions> configureOptions)
        {
            return builder
                .AddScheme<ApiKeyAuthOptions, ApiKeyAuthHandler>(
                    ApiKeyAuthOptions.DefaultScheme,
                    configureOptions);
        }
    }
}
