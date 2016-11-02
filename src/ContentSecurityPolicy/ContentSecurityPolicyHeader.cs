using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace ContentSecurityPolicy
{
    public class ContentSecurityPolicyHeader
    {
        private readonly IList<Directive> _directives;

        public ContentSecurityPolicyHeader()
        {
            _directives = new List<Directive>();
        }

        public ContentSecurityPolicyHeader AddDirective(Directive directive)
        {
            if (directive == null)
            {
                throw new ArgumentNullException(nameof(directive));
            }

            if (_directives.Contains(directive))
            {
                _directives[_directives.IndexOf(directive)].Merge(directive);
            }
            else
            {
                _directives.Add(directive);
            }

            return this;
        }

        public ContentSecurityPolicyHeader ClearDirectives()
        {
            _directives.Clear();

            return this;
        }

        public string Compose()
        {
            var sb = new StringBuilder();

            foreach (var directive in _directives)
            {
                sb.Append(directive.Compose());
            }

            return sb.ToString();
        }

        public void Apply(IHeaderDictionary headers)
        {
            if (headers == null)
            {
                throw new ArgumentNullException(nameof(headers));
            }

            if (_directives.Count > 0)
            {
                headers[Constants.ContentSecurityPolicyHeader] = Compose();
            }
        }
    }
}
