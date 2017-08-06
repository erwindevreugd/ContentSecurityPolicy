using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace ContentSecurityPolicy
{
    public class ContentSecurityPolicyHeaderBuilder
    {
        private readonly IList<Directive> _directives;

        public ContentSecurityPolicyHeaderBuilder()
        {
            _directives = new List<Directive>();
        }

        public bool ReportOnly { get; set; } = false;

        public ContentSecurityPolicyHeaderBuilder AddDirective(Directive directive)
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

        public ContentSecurityPolicyHeaderBuilder ClearDirectives()
        {
            _directives.Clear();

            return this;
        }

        public KeyValuePair<string, string> Compose()
        {
            var sb = new StringBuilder();

            foreach (var directive in _directives)
            {
                sb.Append(directive.Compose());
            }

            var headerKey = ReportOnly ? Constants.ContentSecurityPolicyReportOnlyHeader : Constants.ContentSecurityPolicyHeader;
            var headervalue = sb.ToString();

            return new KeyValuePair<string, string>(headerKey, headervalue);
        }
    }
}
