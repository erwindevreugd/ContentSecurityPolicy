using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ContentSecurityPolicy
{
    public class ContentSecurityPolicyMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ContentSecurityPolicyHeader _header;

        public ContentSecurityPolicyMiddleware(RequestDelegate next, ContentSecurityPolicyHeader header)
        {
            if (next == null)
            {
                throw new ArgumentNullException(nameof(next));
            }

            if (header == null)
            {
                throw new ArgumentNullException(nameof(header));
            }

            _next = next;
            _header = header;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var response = context.Response;

            if (response == null)
            {
                throw new ArgumentNullException(nameof(response));
            }

            _header.Apply(response.Headers);

            await _next(context);
        }
    }
}
