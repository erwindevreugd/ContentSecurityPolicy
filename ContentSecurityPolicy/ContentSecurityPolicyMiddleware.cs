using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ContentSecurityPolicy
{
    public class ContentSecurityPolicyMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly KeyValuePair<string, string> _header;

        public ContentSecurityPolicyMiddleware(RequestDelegate next, ContentSecurityPolicyHeaderBuilder builder)
        {
            if (next == null)
            {
                throw new ArgumentNullException(nameof(next));
            }

            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            _next = next;
            _header = builder.Compose();
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

            Apply(response.Headers);

            await _next(context);
        }

        private void Apply(IHeaderDictionary headers)
        {
            if (headers == null)
            {
                throw new ArgumentNullException(nameof(headers));
            }

            headers[_header.Key] = _header.Value;
        }
    }
}
