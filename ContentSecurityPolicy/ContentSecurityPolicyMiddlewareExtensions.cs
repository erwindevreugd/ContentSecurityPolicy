using System;
using Microsoft.AspNetCore.Builder;

namespace ContentSecurityPolicy
{
    public static class ContentSecurityPolicyMiddlewareExtensions
    {
        public static IApplicationBuilder UseContentSecurityPolicy(this IApplicationBuilder applicationBuilder, ContentSecurityPolicyHeader header)
        {
            if (applicationBuilder == null)
            {
                throw new ArgumentNullException(nameof(applicationBuilder));
            }

            if (header == null)
            {
                throw new ArgumentNullException(nameof(header));
            }

            return applicationBuilder.UseMiddleware<ContentSecurityPolicyMiddleware>(header);
        }
    }
}
